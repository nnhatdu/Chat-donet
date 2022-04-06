using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming

namespace client
{
    public partial class client : Form
    {
        private const int READ_BUFFER_SIZE = 10024;
        private const int PORT_NUM = 1809;

        private static readonly byte[] SALT =
            {0x26, 0xdc, 0xff, 0x00, 0xad, 0xed, 0x7a, 0xee, 0xc5, 0xfe, 0x07, 0xaf, 0x4d, 0x08, 0x22, 0x3c};

        private readonly Dictionary<string, List<string>> chatHistory = new Dictionary<string, List<string>>();
        private readonly byte[] readBuffer = new byte[READ_BUFFER_SIZE];
        private TcpClient Client;
        private string hostname;

        private int mov, movx, movy;
        private string password;
        private string user;

        public client()
        {
            InitializeComponent();
        }

        private string GetLocalIpAddress()
        {
            UnicastIPAddressInformation mostSuitableIp = null;

            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var network in networkInterfaces)
            {
                if (network.OperationalStatus != OperationalStatus.Up)
                    continue;

                var properties = network.GetIPProperties();

                if (properties.GatewayAddresses.Count == 0)
                    continue;

                foreach (var address in properties.UnicastAddresses)
                {
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (IPAddress.IsLoopback(address.Address))
                        continue;

                    if (!address.IsDnsEligible)
                    {
                        if (mostSuitableIp == null)
                            mostSuitableIp = address;
                        continue;
                    }

                    // The best IP is the IP got from DHCP server
                    if (address.PrefixOrigin != PrefixOrigin.Dhcp)
                    {
                        if (mostSuitableIp == null || !mostSuitableIp.IsDnsEligible)
                            mostSuitableIp = address;
                        continue;
                    }

                    return address.Address.ToString();
                }
            }

            return mostSuitableIp != null
                ? mostSuitableIp.Address.ToString()
                : "";
        }

        private static byte[] Encrypt(byte[] plain, string password)
        {
            var rijndael = Rijndael.Create();
            var pdb = new Rfc2898DeriveBytes(password, SALT);
            rijndael.Key = pdb.GetBytes(32);
            rijndael.IV = pdb.GetBytes(16);
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(plain, 0, plain.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        private static byte[] Decrypt(byte[] cipher, string password)
        {
            var rijndael = Rijndael.Create();
            var pdb = new Rfc2898DeriveBytes(password, SALT);
            rijndael.Key = pdb.GetBytes(32);
            rijndael.IV = pdb.GetBytes(16);
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(cipher, 0, cipher.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        private void DoRead(IAsyncResult ar)
        {
            int BytesRead;
            string strMessage;

            try
            {
                // Finish asynchronous read into readBuffer and return number of bytes read.
                BytesRead = Client.GetStream().EndRead(ar);
                if (BytesRead < 1)
                {
                    // if no bytes were read server has close.  Disable input window.
                    MarkAsDisconnected();
                    return;
                }

                // Convert the byte array the message was saved into, minus two for the
                // Chr(13) and Chr(10)
                strMessage = Encoding.UTF8.GetString(readBuffer, 0, BytesRead - 2);
                ProcessCommands(strMessage);
                // Start a new asynchronous read into readBuffer.
                Client.GetStream().BeginRead(readBuffer, 0, READ_BUFFER_SIZE, DoRead, null);
            }
            catch
            {
                MarkAsDisconnected();
            }
        }

        private void MarkAsDisconnected()
        {
            try
            {
                txtInput.ReadOnly = true;
                btnSend.Enabled = false;
            }
            catch
            {
                // ignored
            }
        }

        private void ProcessCommands(string strMessage)
        {
            var dataArray = strMessage.Split((char) 124);
            switch (dataArray[0])
            {
                case "JOIN":
                {
                    UpdateList();
                    lblUserName.Text = "Hello, " + dataArray[1] + " !";
                    break;
                }
                case "CHAT":
                {
                    if (!chatHistory.ContainsKey(dataArray[1]))
                        chatHistory.Add(dataArray[1], new List<string>());
                    chatHistory[dataArray[1]].Add(dataArray[1] + ": " + dataArray[3]);
                    UpdateChat(dataArray[1]);
                    sendnoti.ShowBalloonTip(5000);
                    break;
                }
                case "REFUSE":
                {
                    MessageBox.Show("Invalid Account", "Warning", MessageBoxButtons.OK);
                    AttemptLogin();
                    break;
                }
                case "REFUSEREGISTER":
                {
                    MessageBox.Show("Existed Account", "Warning", MessageBoxButtons.OK);
                    AttemptLogin();
                    break;
                }
                case "LISTUSERS":
                {
                    ListUsers(dataArray);
                    break;
                }
                case "USERINFO":
                {
                    var frm = new Info
                    {
                        label3 = {Text = dataArray[1]},
                        label4 = {Text = dataArray[2]},
                        StartPosition = FormStartPosition.CenterParent
                    };
                    frm.ShowDialog(this);
                    break;
                }
                case "LISTFILE":
                {
                    var files = dataArray[1].Split('$');
                    var frmListFile = new ShowListFile {StartPosition = FormStartPosition.CenterParent};
                    foreach (var item in files)
                        if (item != string.Empty)
                            frmListFile.lsbListFile.Items.Add(item.Substring(item.IndexOf('\\') + 1));

                    if (frmListFile.ShowDialog(this) == DialogResult.OK)
                    {
                        var dialogResult = MessageBox.Show(this, "Do you want to encode before loading?", "Notification",
                            MessageBoxButtons.YesNo);
                        SendData("GETFILE|" +
                                 frmListFile.lsbListFile.GetItemText(frmListFile.lsbListFile.SelectedItem) + "|" +
                                 GetLocalIpAddress().Trim() + "|" + (dialogResult == DialogResult.Yes ? "Y" : "N"));
                        var receiveThread = new Thread(filename =>
                        {
                            var cmd = ((string) filename).Split('|');
                            var listener = new TcpListener(IPAddress.Parse(GetLocalIpAddress()), 3030);
                            var bufferSize = 1024;
                            var bytesRead = 0;
                            var allBytesRead = 0;

                            // Start listening
                            listener.Start();

                            // Accept client
                            var client = listener.AcceptTcpClient();
                            listener.Stop();
                            var netStream = client.GetStream();

                            // Read length of incoming data
                            var length = new byte[4];
                            bytesRead = netStream.Read(length, 0, 4);
                            var dataLength = BitConverter.ToInt32(length, 0);

                            // Read the data
                            var bytesLeft = dataLength;
                            var datas = new byte[dataLength];

                            while (bytesLeft > 0)
                            {
                                var nextPacketSize = bytesLeft > bufferSize ? bufferSize : bytesLeft;
                                bytesRead = netStream.Read(datas, allBytesRead, nextPacketSize);
                                allBytesRead += bytesRead;
                                bytesLeft -= bytesRead;
                            }

                            if (cmd[1] == "Y")
                                datas = Decrypt(datas, "blackpink");
                            // Save to files
                            var frmNewName = new newFileName {StartPosition = FormStartPosition.CenterParent};
                            if (frmNewName.ShowDialog(this) == DialogResult.OK &&
                                frmNewName.txbNewName.Text.Trim() != string.Empty)
                            {
                                if (cmd[0].Contains('.'))
                                    cmd[0] = cmd[0].Substring(cmd[0].LastIndexOf('.'));
                                cmd[0] = frmNewName.txbNewName.Text.Trim() + cmd[0];
                            }
                            else
                            {
                                MessageBox.Show(this, "Invalid new name, name will remain the same", "Notification",
                                    MessageBoxButtons.OK);
                            }

                            if (!Directory.Exists("received"))
                                Directory.CreateDirectory("received");
                            File.WriteAllBytes("received\\" + cmd[0], datas);
                            // Clean up
                            netStream.Close();
                            client.Close();
                        });
                        receiveThread.Start((frmListFile.lsbListFile.GetItemText(frmListFile.lsbListFile.SelectedItem)) + "|" +
                                            (dialogResult == DialogResult.Yes ? "Y" : "N"));
                    }
                    break;
                }
            }
        }

        private void SendData(string data)
        {
            var writer = new StreamWriter(Client.GetStream());
            writer.Write(data + (char) 13);
            writer.Flush();
        }

        private void UpdateChat(string newMessage)
        {
            if (lsbConversation.Items.Contains(newMessage))
                lsbConversation.Items.Remove(newMessage);
            lsbConversation.Items.Insert(0, newMessage);
            if (newMessage == btnInfo.Text && chatHistory.ContainsKey(btnInfo.Text))
            {
                lsbChatBox.Items.Clear();
                foreach (var item in chatHistory[btnInfo.Text])
                    lsbChatBox.Items.Add(item);
            }
        }

        private static string Hash(string input)
        {
            return string.Join("",
                new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input)).Select(x => x.ToString("X2")).ToArray());
        }

        private void AttemptLogin()
        {
            var frmLogin = new login {StartPosition = FormStartPosition.CenterParent};
            if (frmLogin.ShowDialog(this) == DialogResult.Cancel)
            {
                Dispose();
                Close();
            }
            user = frmLogin.txtUsername.Text;
            password = frmLogin.txtPassword.Text;
            var check = frmLogin.chkEncrypt.CheckState == CheckState.Checked;
            if (frmLogin.cmbLogIn.SelectedIndex == 0)
                SendData("CONNECT|" + frmLogin.txtUsername.Text + "|" +
                         (check ? Hash(frmLogin.txtPassword.Text) : frmLogin.txtPassword.Text) + "|" +
                         (check ? "1" : "0"));
            else
                SendData("REGISTER|" + frmLogin.txtUsername.Text + "|" + frmLogin.txtTen.Text + "|" +
                         (check ? Hash(frmLogin.txtPassword.Text) : frmLogin.txtPassword.Text) + "|" +
                         frmLogin.dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "|" +
                         (check ? "1" : "0"));
            frmLogin.Dispose();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            var frmName = new name {StartPosition = FormStartPosition.CenterParent};
            if (frmName.ShowDialog(this) == DialogResult.OK)
            {
                if (frmName.txbNewName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Invalid name", "Notification", MessageBoxButtons.OK);
                    frmName.Dispose();
                    return;
                }

                lblUserName.Text = "Hello, " + frmName.txbNewName.Text.Trim() + " !";
                SendData("CHANGENAME|" + frmName.txbNewName.Text.Trim());
                frmName.Dispose();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var frmChangePassword = new password {StartPosition = FormStartPosition.CenterParent};
            if (frmChangePassword.ShowDialog(this) == DialogResult.OK)
            {
                if (frmChangePassword.txbOldPassword.Text != password)
                {
                    MessageBox.Show("Password does not match", "Notification", MessageBoxButtons.OK);
                    frmChangePassword.Dispose();
                    return;
                }

                if (frmChangePassword.txbNewPassword.Text == string.Empty)
                {
                    MessageBox.Show("Invalid password", "Notification", MessageBoxButtons.OK);
                    frmChangePassword.Dispose();
                    return;
                }

                password = frmChangePassword.txbNewPassword.Text;
                var isEncrypted = frmChangePassword.chkEncrypt.CheckState == CheckState.Checked;
                SendData("CHANGEPASS|" +
                         (isEncrypted
                             ? Hash(frmChangePassword.txbNewPassword.Text)
                             : frmChangePassword.txbNewPassword.Text) + "|" + (isEncrypted ? "1" : "0"));
            }
        }

        private void ListUsers(string[] users)
        {
            lsbActiveUser.Items.Clear();
            var c = users.Skip(1).Where(item => item != user);
            if (!c.Contains(btnInfo.Text))
                btnSend.Enabled = false;
            foreach (var item in c)
                lsbActiveUser.Items.Add(item);
        }

        private void UpdateList()
        {
            lock (lsbActiveUser)
            {
                lsbActiveUser.Items.Clear();
                SendData("REQUESTUSERS");
            }
        }

        private void client_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SendData("DISCONNECT");
            }
            catch
            {
                //ignored
            }
        }

        private void client_Load(object sender, EventArgs e)
        {
            btnInfo.Text = "";
            btnInfo.Enabled = false;
            btnSend.Enabled = false;
            again:
            var frmIP = new IP {StartPosition = FormStartPosition.CenterParent};
            if (frmIP.ShowDialog(this) == DialogResult.Cancel)
            {
                Dispose();
                Close();
            }
            hostname = frmIP.txtIP.Text;
            frmIP.Dispose();
            try
            {
                if (hostname.Trim() == string.Empty)
                    throw new ArgumentException("");
                Client = new TcpClient();
                if (!Client.ConnectAsync(hostname, PORT_NUM).Wait(1000))
                    throw new InvalidProgramException("");
                Client.GetStream().BeginRead(readBuffer, 0, READ_BUFFER_SIZE, DoRead, null);
                Show();
                AttemptLogin();
            }
            catch
            {
                MessageBox.Show("Unable to Connect to Server. Please log in again.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto again;
            }

            changeMenu.Height = 41;
            file.Height = 41;
        }

        private void lsbConversation_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnInfo.Text != lsbConversation.Text)
                btnInfo.Text = lsbConversation.Text;
            UpdateChat(btnInfo.Text);
        }

        private void lsbActiveUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnInfo.Text != lsbActiveUser.Text)
                btnInfo.Text = lsbActiveUser.Text;
            else UpdateChat(btnInfo.Text);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SendData("USERINFO|" + btnInfo.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == string.Empty) return;
            if (!chatHistory.ContainsKey(btnInfo.Text))
                chatHistory.Add(btnInfo.Text, new List<string>());
            chatHistory[btnInfo.Text].Add("You: " + txtInput.Text);
            SendData("CHAT|" + user + "|" + btnInfo.Text + "|" + txtInput.Text);
            txtInput.Text = string.Empty;
            UpdateChat(btnInfo.Text);
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1) SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            var frmChangeDate = new dob {StartPosition = FormStartPosition.CenterParent};
            if (frmChangeDate.ShowDialog(this) == DialogResult.OK)
                SendData("CHANGEDATE|" + frmChangeDate.dtbDOB.Value.ToString("dd/MM/yyyy"));
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*", FilterIndex = 1, Multiselect = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var dir = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('\\') + 1);
                var frmNewName = new newFileName {StartPosition = FormStartPosition.CenterParent};
                if (frmNewName.ShowDialog() == DialogResult.OK)
                {
                    if (frmNewName.txbNewName.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("File name cannot be empty. File name will remain the same", "Notification",
                            MessageBoxButtons.OK);
                    }
                    else
                    {
                        dir = dir.Trim();
                        if (dir.Contains('.'))
                            dir = dir.Substring(dir.IndexOf('.'));
                        else dir = string.Empty;
                        dir = frmNewName.txbNewName.Text + dir;
                    }
                }

                var dia = MessageBox.Show("Do you want to encode while sending file to server?", "Notification",
                    MessageBoxButtons.YesNo);
                SendData("DATA|" + dir + "|" + GetLocalIpAddress().Trim() + "|" +
                         (dia == DialogResult.Yes ? "Y" : "N"));
                var sendThread = new Thread(directory =>
                {
                    var cmd = ((string) directory).Split('|');
                    var listener = new TcpListener(IPAddress.Parse(GetLocalIpAddress().Trim()), 3003);
                    listener.Start();
                    var client = listener.AcceptTcpClient();
                    listener.Stop();
                    var netStream = client.GetStream();
                    var datas = File.ReadAllBytes(cmd[0]);
                    if (cmd[1] == "Y")
                        datas = Encrypt(datas, "blackpink");
                    // Build the package
                    var dataLength = BitConverter.GetBytes(datas.Length);
                    var package = new byte[4 + datas.Length];
                    dataLength.CopyTo(package, 0);
                    datas.CopyTo(package, 4);

                    // Send to server
                    var bytesSent = 0;
                    var bytesLeft = package.Length;

                    while (bytesLeft > 0)
                    {
                        var nextPacketSize = bytesLeft > 1024 ? 1024 : bytesLeft;

                        netStream.Write(package, bytesSent, nextPacketSize);
                        bytesSent += nextPacketSize;
                        bytesLeft -= nextPacketSize;
                    }

                    netStream.Flush();
                    netStream.Dispose();
                    netStream.Close();
                    client.Dispose();
                    client.Close();
                });
                //file name - isencrypted
                sendThread.Start(openFileDialog.FileName + "|" + (dia == DialogResult.Yes ? "Y" : "N"));
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            SendData("GETLISTFILE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (changeMenu.Height == 164) changeMenu.Height = 41;
            else changeMenu.Height = 164;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (file.Height == 116) file.Height = 41;
            else file.Height = 116;
        }

        private void btnInfo_TextChanged(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
            btnInfo.Enabled = true;
            if (!lsbActiveUser.Items.Contains(btnInfo.Text))
            {
                btnSend.Enabled = false;
                btnInfo.Enabled = false;
                return;
            }

            lsbChatBox.Items.Clear();
            if (chatHistory.ContainsKey(btnInfo.Text))
                foreach (var item in chatHistory[btnInfo.Text])
                    lsbChatBox.Items.Add(item);
        }
        private void closeBut_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void hideBut_Click_1(object sender, EventArgs e)
        {
            SuspendLayout();
            WindowState = FormWindowState.Minimized;
        }
    }
}
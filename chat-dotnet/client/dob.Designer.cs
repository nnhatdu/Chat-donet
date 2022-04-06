
namespace client
{
    partial class dob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dob));
            this.label1 = new System.Windows.Forms.Label();
            this.dtbDOB = new System.Windows.Forms.DateTimePicker();
            this.btnChange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hideBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day of Birth";
            // 
            // dtbDOB
            // 
            this.dtbDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dtbDOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.dtbDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.dtbDOB.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.dtbDOB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.dtbDOB.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.dtbDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbDOB.Location = new System.Drawing.Point(159, 72);
            this.dtbDOB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtbDOB.Name = "dtbDOB";
            this.dtbDOB.Size = new System.Drawing.Size(179, 32);
            this.dtbDOB.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.AutoSize = true;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.btnChange.FlatAppearance.BorderSize = 2;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.btnChange.Location = new System.Drawing.Point(354, 66);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(82, 48);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "OK";
            this.btnChange.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 37);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // hideBut
            // 
            this.hideBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.hideBut.FlatAppearance.BorderSize = 3;
            this.hideBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.hideBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.hideBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBut.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7F);
            this.hideBut.Location = new System.Drawing.Point(372, 13);
            this.hideBut.Name = "hideBut";
            this.hideBut.Size = new System.Drawing.Size(33, 33);
            this.hideBut.TabIndex = 13;
            this.hideBut.Text = "-";
            this.hideBut.UseVisualStyleBackColor = false;
            this.hideBut.Click += new System.EventHandler(this.hideBut_Click);
            // 
            // closeBut
            // 
            this.closeBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.closeBut.FlatAppearance.BorderSize = 3;
            this.closeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(55)))));
            this.closeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Felix Titling", 7F, System.Drawing.FontStyle.Bold);
            this.closeBut.Location = new System.Drawing.Point(411, 13);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(33, 33);
            this.closeBut.TabIndex = 12;
            this.closeBut.Text = "X";
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "CHANGE DAY OF BIRTH";
            // 
            // dob
            // 
            this.AcceptButton = this.btnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
            this.CancelButton = this.closeBut;
            this.ClientSize = new System.Drawing.Size(456, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hideBut);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.dtbDOB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(97)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dob";
            this.Text = "dob";
            this.Load += new System.EventHandler(this.dob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtbDOB;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hideBut;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Label label2;
    }
}
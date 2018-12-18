namespace SendMail
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.GroupBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.texSmtp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.texPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.texPass = new System.Windows.Forms.TextBox();
            this.texUser = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texTo = new System.Windows.Forms.TextBox();
            this.texCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "To:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.chkSSL);
            this.Options.Controls.Add(this.texSmtp);
            this.Options.Controls.Add(this.label8);
            this.Options.Controls.Add(this.texPort);
            this.Options.Controls.Add(this.label7);
            this.Options.Controls.Add(this.texPass);
            this.Options.Controls.Add(this.texUser);
            this.Options.Controls.Add(this.btnSend);
            this.Options.Controls.Add(this.label4);
            this.Options.Controls.Add(this.label6);
            this.Options.Location = new System.Drawing.Point(152, 338);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(523, 100);
            this.Options.TabIndex = 3;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(301, 21);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(46, 17);
            this.chkSSL.TabIndex = 1;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // texSmtp
            // 
            this.texSmtp.Location = new System.Drawing.Point(229, 71);
            this.texSmtp.Name = "texSmtp";
            this.texSmtp.Size = new System.Drawing.Size(193, 20);
            this.texSmtp.TabIndex = 4;
            this.texSmtp.Text = "smtp.gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "SMTP:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // texPort
            // 
            this.texPort.Location = new System.Drawing.Point(78, 71);
            this.texPort.Name = "texPort";
            this.texPort.Size = new System.Drawing.Size(80, 20);
            this.texPort.TabIndex = 3;
            this.texPort.Text = "587";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Port:";
            // 
            // texPass
            // 
            this.texPass.Location = new System.Drawing.Point(78, 45);
            this.texPass.Name = "texPass";
            this.texPass.PasswordChar = '*';
            this.texPass.Size = new System.Drawing.Size(195, 20);
            this.texPass.TabIndex = 2;
            // 
            // texUser
            // 
            this.texUser.Location = new System.Drawing.Point(78, 19);
            this.texUser.Name = "texUser";
            this.texUser.Size = new System.Drawing.Size(195, 20);
            this.texUser.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(442, 68);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username:";
            // 
            // texTo
            // 
            this.texTo.Location = new System.Drawing.Point(152, 53);
            this.texTo.Name = "texTo";
            this.texTo.Size = new System.Drawing.Size(439, 20);
            this.texTo.TabIndex = 0;
            this.texTo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texCC
            // 
            this.texCC.Location = new System.Drawing.Point(152, 79);
            this.texCC.Name = "texCC";
            this.texCC.Size = new System.Drawing.Size(439, 20);
            this.texCC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CC:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // texSubject
            // 
            this.texSubject.Location = new System.Drawing.Point(152, 105);
            this.texSubject.Name = "texSubject";
            this.texSubject.Size = new System.Drawing.Size(439, 20);
            this.texSubject.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subject:";
            // 
            // texMsg
            // 
            this.texMsg.Location = new System.Drawing.Point(152, 131);
            this.texMsg.Multiline = true;
            this.texMsg.Name = "texMsg";
            this.texMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texMsg.Size = new System.Drawing.Size(523, 201);
            this.texMsg.TabIndex = 4;
            this.texMsg.Text = " ";
            this.texMsg.TextChanged += new System.EventHandler(this.texMsg_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Test Form for Sending mails";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texMsg);
            this.Controls.Add(this.texSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texTo);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send mail";
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox texTo;
        private System.Windows.Forms.TextBox texCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texSmtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texPass;
        private System.Windows.Forms.TextBox texUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSSL;
    }
}


namespace Maily
{
    partial class MailyForm
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
            this.toLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.toBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.loginForm = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.sendForm = new System.Windows.Forms.TabPage();
            this.sendButton = new System.Windows.Forms.Button();
            this.inboxForm = new System.Windows.Forms.TabPage();
            this.getMailButton = new System.Windows.Forms.Button();
            this.lettersView = new System.Windows.Forms.ListView();
            this.letterContent = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.loginForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sendForm.SuspendLayout();
            this.inboxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(14, 35);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(34, 20);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(14, 84);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(75, 20);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subject:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(14, 132);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(86, 20);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message:";
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(160, 34);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(569, 20);
            this.toBox.TabIndex = 3;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(160, 86);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(569, 20);
            this.subjectBox.TabIndex = 4;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(160, 134);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(569, 199);
            this.messageBox.TabIndex = 5;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.loginForm);
            this.tabs.Controls.Add(this.sendForm);
            this.tabs.Controls.Add(this.inboxForm);
            this.tabs.Location = new System.Drawing.Point(2, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(808, 462);
            this.tabs.TabIndex = 6;
            // 
            // loginForm
            // 
            this.loginForm.Controls.Add(this.logOutButton);
            this.loginForm.Controls.Add(this.loginButton);
            this.loginForm.Controls.Add(this.groupBox1);
            this.loginForm.Location = new System.Drawing.Point(4, 22);
            this.loginForm.Name = "loginForm";
            this.loginForm.Padding = new System.Windows.Forms.Padding(3);
            this.loginForm.Size = new System.Drawing.Size(800, 436);
            this.loginForm.TabIndex = 2;
            this.loginForm.Text = "Login";
            this.loginForm.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(244, 275);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(343, 45);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hostBox);
            this.groupBox1.Controls.Add(this.smtpLabel);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.usernameBox);
            this.groupBox1.Controls.Add(this.portLabel);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Location = new System.Drawing.Point(124, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(171, 123);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(384, 20);
            this.hostBox.TabIndex = 7;
            this.hostBox.Text = "smtp.gmail.com";
            // 
            // smtpLabel
            // 
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtpLabel.Location = new System.Drawing.Point(22, 123);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(61, 20);
            this.smtpLabel.TabIndex = 6;
            this.smtpLabel.Text = "SMTP:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(171, 90);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(384, 20);
            this.portBox.TabIndex = 5;
            this.portBox.Text = "587";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(171, 58);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(384, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(171, 27);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(384, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(22, 90);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(47, 20);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(22, 56);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(22, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(96, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // sendForm
            // 
            this.sendForm.Controls.Add(this.sendButton);
            this.sendForm.Controls.Add(this.messageBox);
            this.sendForm.Controls.Add(this.toLabel);
            this.sendForm.Controls.Add(this.subjectBox);
            this.sendForm.Controls.Add(this.subjectLabel);
            this.sendForm.Controls.Add(this.toBox);
            this.sendForm.Controls.Add(this.messageLabel);
            this.sendForm.Location = new System.Drawing.Point(4, 22);
            this.sendForm.Name = "sendForm";
            this.sendForm.Padding = new System.Windows.Forms.Padding(3);
            this.sendForm.Size = new System.Drawing.Size(800, 436);
            this.sendForm.TabIndex = 0;
            this.sendForm.Text = "SendForm";
            this.sendForm.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(298, 357);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(294, 38);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // inboxForm
            // 
            this.inboxForm.Controls.Add(this.letterContent);
            this.inboxForm.Controls.Add(this.getMailButton);
            this.inboxForm.Controls.Add(this.lettersView);
            this.inboxForm.Location = new System.Drawing.Point(4, 22);
            this.inboxForm.Name = "inboxForm";
            this.inboxForm.Padding = new System.Windows.Forms.Padding(3);
            this.inboxForm.Size = new System.Drawing.Size(800, 436);
            this.inboxForm.TabIndex = 1;
            this.inboxForm.Text = "Inbox";
            this.inboxForm.UseVisualStyleBackColor = true;
            // 
            // getMailButton
            // 
            this.getMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMailButton.Location = new System.Drawing.Point(3, 6);
            this.getMailButton.Name = "getMailButton";
            this.getMailButton.Size = new System.Drawing.Size(162, 23);
            this.getMailButton.TabIndex = 2;
            this.getMailButton.Text = "Get Mail";
            this.getMailButton.UseVisualStyleBackColor = true;
            this.getMailButton.Click += new System.EventHandler(this.getMailButton_Click);
            // 
            // lettersView
            // 
            this.lettersView.HideSelection = false;
            this.lettersView.Location = new System.Drawing.Point(3, 38);
            this.lettersView.Name = "lettersView";
            this.lettersView.Size = new System.Drawing.Size(162, 384);
            this.lettersView.TabIndex = 0;
            this.lettersView.UseCompatibleStateImageBehavior = false;
            this.lettersView.View = System.Windows.Forms.View.Details;
            this.lettersView.SelectedIndexChanged += new System.EventHandler(this.lettersView_SelectedIndexChanged);
            // 
            // letterContent
            // 
            this.letterContent.Location = new System.Drawing.Point(171, 16);
            this.letterContent.Multiline = true;
            this.letterContent.Name = "letterContent";
            this.letterContent.Size = new System.Drawing.Size(608, 406);
            this.letterContent.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 467);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 24);
            this.statusLabel.TabIndex = 9;
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(244, 326);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(343, 45);
            this.logOutButton.TabIndex = 9;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // MailyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 492);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tabs);
            this.Name = "MailyForm";
            this.Text = "Maily";
            this.tabs.ResumeLayout(false);
            this.loginForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sendForm.ResumeLayout(false);
            this.sendForm.PerformLayout();
            this.inboxForm.ResumeLayout(false);
            this.inboxForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage sendForm;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TabPage inboxForm;
        private System.Windows.Forms.ListView lettersView;
        private System.Windows.Forms.Button getMailButton;
        private System.Windows.Forms.TabPage loginForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox letterContent;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button logOutButton;
    }
}


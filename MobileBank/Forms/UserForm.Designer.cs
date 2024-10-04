namespace MobileBank.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.PersonalDataPanel = new System.Windows.Forms.Panel();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MailPictureBox = new System.Windows.Forms.PictureBox();
            this.PhonePictureBox = new System.Windows.Forms.PictureBox();
            this.PersonalDataLabel = new System.Windows.Forms.Label();
            this.AnotherProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.RefreshDataButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangeMailButton = new System.Windows.Forms.Button();
            this.ChangePhoneButton = new System.Windows.Forms.Button();
            this.SettingsPictureBox = new System.Windows.Forms.PictureBox();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.PersonalDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherProfilePictureBox)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ProfilePanel.Controls.Add(this.CloseButton);
            this.ProfilePanel.Controls.Add(this.ProfilePictureBox);
            this.ProfilePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(800, 75);
            this.ProfilePanel.TabIndex = 116;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(735, 22);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 33);
            this.CloseButton.TabIndex = 133;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePictureBox.Image")));
            this.ProfilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(73, 75);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            // 
            // PersonalDataPanel
            // 
            this.PersonalDataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PersonalDataPanel.Controls.Add(this.MailLabel);
            this.PersonalDataPanel.Controls.Add(this.PhoneLabel);
            this.PersonalDataPanel.Controls.Add(this.FIOLabel);
            this.PersonalDataPanel.Controls.Add(this.Label5);
            this.PersonalDataPanel.Controls.Add(this.Label4);
            this.PersonalDataPanel.Controls.Add(this.Label3);
            this.PersonalDataPanel.Controls.Add(this.MailPictureBox);
            this.PersonalDataPanel.Controls.Add(this.PhonePictureBox);
            this.PersonalDataPanel.Controls.Add(this.PersonalDataLabel);
            this.PersonalDataPanel.Controls.Add(this.AnotherProfilePictureBox);
            this.PersonalDataPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalDataPanel.Location = new System.Drawing.Point(0, 110);
            this.PersonalDataPanel.Name = "PersonalDataPanel";
            this.PersonalDataPanel.Size = new System.Drawing.Size(400, 328);
            this.PersonalDataPanel.TabIndex = 117;
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailLabel.ForeColor = System.Drawing.Color.White;
            this.MailLabel.Location = new System.Drawing.Point(95, 234);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(0, 22);
            this.MailLabel.TabIndex = 139;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneLabel.Location = new System.Drawing.Point(95, 155);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(0, 22);
            this.PhoneLabel.TabIndex = 138;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.ForeColor = System.Drawing.Color.White;
            this.FIOLabel.Location = new System.Drawing.Point(95, 90);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(0, 22);
            this.FIOLabel.TabIndex = 137;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(95, 206);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(138, 22);
            this.Label5.TabIndex = 136;
            this.Label5.Text = "Ваша эл. почта";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(95, 127);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 22);
            this.Label4.TabIndex = 135;
            this.Label4.Text = "Телефон";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(95, 62);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 22);
            this.Label3.TabIndex = 134;
            this.Label3.Text = "ФИО";
            // 
            // MailPictureBox
            // 
            this.MailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MailPictureBox.Image")));
            this.MailPictureBox.Location = new System.Drawing.Point(28, 206);
            this.MailPictureBox.Name = "MailPictureBox";
            this.MailPictureBox.Size = new System.Drawing.Size(50, 50);
            this.MailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MailPictureBox.TabIndex = 112;
            this.MailPictureBox.TabStop = false;
            // 
            // PhonePictureBox
            // 
            this.PhonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PhonePictureBox.Image")));
            this.PhonePictureBox.Location = new System.Drawing.Point(28, 127);
            this.PhonePictureBox.Name = "PhonePictureBox";
            this.PhonePictureBox.Size = new System.Drawing.Size(50, 50);
            this.PhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhonePictureBox.TabIndex = 111;
            this.PhonePictureBox.TabStop = false;
            // 
            // PersonalDataLabel
            // 
            this.PersonalDataLabel.AutoSize = true;
            this.PersonalDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalDataLabel.Location = new System.Drawing.Point(23, 18);
            this.PersonalDataLabel.Name = "PersonalDataLabel";
            this.PersonalDataLabel.Size = new System.Drawing.Size(189, 29);
            this.PersonalDataLabel.TabIndex = 110;
            this.PersonalDataLabel.Text = "Личные данные";
            // 
            // AnotherProfilePictureBox
            // 
            this.AnotherProfilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AnotherProfilePictureBox.Image")));
            this.AnotherProfilePictureBox.Location = new System.Drawing.Point(28, 62);
            this.AnotherProfilePictureBox.Name = "AnotherProfilePictureBox";
            this.AnotherProfilePictureBox.Size = new System.Drawing.Size(50, 50);
            this.AnotherProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnotherProfilePictureBox.TabIndex = 0;
            this.AnotherProfilePictureBox.TabStop = false;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SettingsPanel.Controls.Add(this.SettingsLabel);
            this.SettingsPanel.Controls.Add(this.RefreshDataButton);
            this.SettingsPanel.Controls.Add(this.ChangePasswordButton);
            this.SettingsPanel.Controls.Add(this.ChangeMailButton);
            this.SettingsPanel.Controls.Add(this.ChangePhoneButton);
            this.SettingsPanel.Controls.Add(this.SettingsPictureBox);
            this.SettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsPanel.Location = new System.Drawing.Point(406, 110);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(394, 328);
            this.SettingsPanel.TabIndex = 118;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location = new System.Drawing.Point(70, 30);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(135, 29);
            this.SettingsLabel.TabIndex = 113;
            this.SettingsLabel.Text = "Настройки";
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.RefreshDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshDataButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.RefreshDataButton.FlatAppearance.BorderSize = 0;
            this.RefreshDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshDataButton.ForeColor = System.Drawing.Color.White;
            this.RefreshDataButton.Location = new System.Drawing.Point(14, 251);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Size = new System.Drawing.Size(347, 49);
            this.RefreshDataButton.TabIndex = 132;
            this.RefreshDataButton.Text = "Обновить данные";
            this.RefreshDataButton.UseVisualStyleBackColor = false;
            this.RefreshDataButton.Click += new System.EventHandler(this.RefreshDataButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordButton.Location = new System.Drawing.Point(14, 196);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(347, 49);
            this.ChangePasswordButton.TabIndex = 131;
            this.ChangePasswordButton.Text = "Изменить пароль для аккаунта";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangeMailButton
            // 
            this.ChangeMailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.ChangeMailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeMailButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.ChangeMailButton.FlatAppearance.BorderSize = 0;
            this.ChangeMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeMailButton.ForeColor = System.Drawing.Color.White;
            this.ChangeMailButton.Location = new System.Drawing.Point(14, 141);
            this.ChangeMailButton.Name = "ChangeMailButton";
            this.ChangeMailButton.Size = new System.Drawing.Size(347, 49);
            this.ChangeMailButton.TabIndex = 130;
            this.ChangeMailButton.Text = "Сменить эл. почту";
            this.ChangeMailButton.UseVisualStyleBackColor = false;
            this.ChangeMailButton.Click += new System.EventHandler(this.ChangeMailButton_Click);
            // 
            // ChangePhoneButton
            // 
            this.ChangePhoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.ChangePhoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePhoneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.ChangePhoneButton.FlatAppearance.BorderSize = 0;
            this.ChangePhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePhoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePhoneButton.ForeColor = System.Drawing.Color.White;
            this.ChangePhoneButton.Location = new System.Drawing.Point(14, 86);
            this.ChangePhoneButton.Name = "ChangePhoneButton";
            this.ChangePhoneButton.Size = new System.Drawing.Size(347, 49);
            this.ChangePhoneButton.TabIndex = 129;
            this.ChangePhoneButton.Text = "Изменить номер телефона";
            this.ChangePhoneButton.UseVisualStyleBackColor = false;
            this.ChangePhoneButton.Click += new System.EventHandler(this.ChangePhoneButton_Click);
            // 
            // SettingsPictureBox
            // 
            this.SettingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SettingsPictureBox.Image")));
            this.SettingsPictureBox.Location = new System.Drawing.Point(14, 18);
            this.SettingsPictureBox.Name = "SettingsPictureBox";
            this.SettingsPictureBox.Size = new System.Drawing.Size(50, 50);
            this.SettingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsPictureBox.TabIndex = 0;
            this.SettingsPictureBox.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.PersonalDataPanel);
            this.Controls.Add(this.ProfilePanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.PersonalDataPanel.ResumeLayout(false);
            this.PersonalDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherProfilePictureBox)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Panel PersonalDataPanel;
        private System.Windows.Forms.PictureBox AnotherProfilePictureBox;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.PictureBox SettingsPictureBox;
        private System.Windows.Forms.Label PersonalDataLabel;
        private System.Windows.Forms.PictureBox MailPictureBox;
        private System.Windows.Forms.PictureBox PhonePictureBox;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Button RefreshDataButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ChangeMailButton;
        private System.Windows.Forms.Button ChangePhoneButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
    }
}
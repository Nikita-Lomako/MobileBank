namespace MobileBank.Forms
{
    partial class ChangePhoneNumber
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.EnterPhoneLabel = new System.Windows.Forms.Label();
            this.ChangePhoneButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(416, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 25);
            this.CloseButton.TabIndex = 134;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EnterPhoneLabel
            // 
            this.EnterPhoneLabel.AutoSize = true;
            this.EnterPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterPhoneLabel.Location = new System.Drawing.Point(50, 61);
            this.EnterPhoneLabel.Name = "EnterPhoneLabel";
            this.EnterPhoneLabel.Size = new System.Drawing.Size(327, 25);
            this.EnterPhoneLabel.TabIndex = 135;
            this.EnterPhoneLabel.Text = "Введите новый номер телефона:";
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
            this.ChangePhoneButton.Location = new System.Drawing.Point(55, 166);
            this.ChangePhoneButton.Name = "ChangePhoneButton";
            this.ChangePhoneButton.Size = new System.Drawing.Size(347, 49);
            this.ChangePhoneButton.TabIndex = 136;
            this.ChangePhoneButton.Text = "Изменить номер телефона";
            this.ChangePhoneButton.UseVisualStyleBackColor = false;
            this.ChangePhoneButton.Click += new System.EventHandler(this.ChangePhoneButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberTextBox.ForeColor = System.Drawing.Color.White;
            this.NumberTextBox.Location = new System.Drawing.Point(55, 102);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberTextBox.Size = new System.Drawing.Size(346, 31);
            this.NumberTextBox.TabIndex = 137;
            this.NumberTextBox.Text = "0000000000000000";
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePanel.Location = new System.Drawing.Point(55, 139);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(346, 3);
            this.NamePanel.TabIndex = 138;
            // 
            // ChangePhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.ChangePhoneButton);
            this.Controls.Add(this.EnterPhoneLabel);
            this.Controls.Add(this.CloseButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label EnterPhoneLabel;
        private System.Windows.Forms.Button ChangePhoneButton;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Panel NamePanel;
    }
}
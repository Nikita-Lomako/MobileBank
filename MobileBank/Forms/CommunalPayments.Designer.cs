namespace MobileBank.Forms
{
    partial class CommunalPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommunalPayments));
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.ComboBoxCommunalPayment = new System.Windows.Forms.ComboBox();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.CardToTextBox = new System.Windows.Forms.TextBox();
            this.CVVTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CommunalPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonalAccountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommunalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(431, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 27);
            this.CloseButton.TabIndex = 87;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(286, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 142;
            this.label1.Text = "BYN";
            // 
            // SumTextBox
            // 
            this.SumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.ForeColor = System.Drawing.Color.White;
            this.SumTextBox.Location = new System.Drawing.Point(29, 238);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SumTextBox.Size = new System.Drawing.Size(251, 27);
            this.SumTextBox.TabIndex = 141;
            // 
            // ComboBoxCommunalPayment
            // 
            this.ComboBoxCommunalPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ComboBoxCommunalPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxCommunalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxCommunalPayment.ForeColor = System.Drawing.Color.White;
            this.ComboBoxCommunalPayment.FormattingEnabled = true;
            this.ComboBoxCommunalPayment.Location = new System.Drawing.Point(29, 103);
            this.ComboBoxCommunalPayment.Name = "ComboBoxCommunalPayment";
            this.ComboBoxCommunalPayment.Size = new System.Drawing.Size(251, 37);
            this.ComboBoxCommunalPayment.TabIndex = 140;
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CardPanel.Controls.Add(this.CardToTextBox);
            this.CardPanel.Controls.Add(this.CVVTextBox);
            this.CardPanel.Controls.Add(this.CardNumberTextBox);
            this.CardPanel.Controls.Add(this.panel5);
            this.CardPanel.Controls.Add(this.NamePanel);
            this.CardPanel.Controls.Add(this.label10);
            this.CardPanel.Controls.Add(this.label3);
            this.CardPanel.Controls.Add(this.label12);
            this.CardPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardPanel.Location = new System.Drawing.Point(29, 295);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(429, 177);
            this.CardPanel.TabIndex = 143;
            // 
            // CardToTextBox
            // 
            this.CardToTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CardToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardToTextBox.ForeColor = System.Drawing.Color.White;
            this.CardToTextBox.Location = new System.Drawing.Point(14, 122);
            this.CardToTextBox.Name = "CardToTextBox";
            this.CardToTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardToTextBox.Size = new System.Drawing.Size(61, 23);
            this.CardToTextBox.TabIndex = 127;
            this.CardToTextBox.Text = "7/24";
            // 
            // CVVTextBox
            // 
            this.CVVTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CVVTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CVVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CVVTextBox.ForeColor = System.Drawing.Color.White;
            this.CVVTextBox.Location = new System.Drawing.Point(208, 122);
            this.CVVTextBox.Name = "CVVTextBox";
            this.CVVTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CVVTextBox.Size = new System.Drawing.Size(43, 23);
            this.CVVTextBox.TabIndex = 126;
            this.CVVTextBox.Text = "***";
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CardNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.CardNumberTextBox.Location = new System.Drawing.Point(15, 36);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardNumberTextBox.Size = new System.Drawing.Size(312, 23);
            this.CardNumberTextBox.TabIndex = 97;
            this.CardNumberTextBox.Text = "0000000000000000";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(11, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 4);
            this.panel5.TabIndex = 111;
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePanel.Location = new System.Drawing.Point(14, 65);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(375, 4);
            this.NamePanel.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(204, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 123;
            this.label10.Text = "CVV-код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 109;
            this.label3.Text = "Номер карты";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 22);
            this.label12.TabIndex = 125;
            this.label12.Text = "Срок действия";
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.PaymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentButton.ForeColor = System.Drawing.Color.White;
            this.PaymentButton.Location = new System.Drawing.Point(29, 490);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(429, 52);
            this.PaymentButton.TabIndex = 130;
            this.PaymentButton.Text = "Оплатить";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 29);
            this.label2.TabIndex = 144;
            this.label2.Text = "Коммунальные платежи";
            // 
            // CommunalPictureBox
            // 
            this.CommunalPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CommunalPictureBox.Image")));
            this.CommunalPictureBox.Location = new System.Drawing.Point(12, 12);
            this.CommunalPictureBox.Name = "CommunalPictureBox";
            this.CommunalPictureBox.Size = new System.Drawing.Size(50, 50);
            this.CommunalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CommunalPictureBox.TabIndex = 145;
            this.CommunalPictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 146;
            this.label6.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 147;
            this.label4.Text = "Личный счет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 148;
            this.label5.Text = "С карты";
            // 
            // PersonalAccountTextBox
            // 
            this.PersonalAccountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PersonalAccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonalAccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalAccountTextBox.ForeColor = System.Drawing.Color.White;
            this.PersonalAccountTextBox.Location = new System.Drawing.Point(29, 179);
            this.PersonalAccountTextBox.Name = "PersonalAccountTextBox";
            this.PersonalAccountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PersonalAccountTextBox.Size = new System.Drawing.Size(251, 27);
            this.PersonalAccountTextBox.TabIndex = 149;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 150;
            this.label7.Text = "Услуги";
            // 
            // CommunalPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(470, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PersonalAccountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommunalPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.ComboBoxCommunalPayment);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CommunalPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommunalPayments";
            this.Load += new System.EventHandler(this.CommunalPayments_Load);
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommunalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.ComboBox ComboBoxCommunalPayment;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.TextBox CardToTextBox;
        private System.Windows.Forms.TextBox CVVTextBox;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CommunalPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PersonalAccountTextBox;
        private System.Windows.Forms.Label label7;
    }
}
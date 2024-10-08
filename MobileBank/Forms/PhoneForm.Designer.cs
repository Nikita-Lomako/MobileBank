namespace MobileBank.Forms
{
    partial class PhoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.CardToTextBox = new System.Windows.Forms.TextBox();
            this.CVVTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RefillAccountButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PhonePictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlagPictureBox = new System.Windows.Forms.PictureBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.ComboBoxOperator = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalSumLabel = new System.Windows.Forms.Label();
            this.CommisionLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhonePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(561, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 27);
            this.CloseButton.TabIndex = 86;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.CardPanel.Location = new System.Drawing.Point(68, 425);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(460, 187);
            this.CardPanel.TabIndex = 114;
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
            // RefillAccountButton
            // 
            this.RefillAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.RefillAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefillAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.RefillAccountButton.FlatAppearance.BorderSize = 0;
            this.RefillAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefillAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefillAccountButton.ForeColor = System.Drawing.Color.White;
            this.RefillAccountButton.Location = new System.Drawing.Point(68, 629);
            this.RefillAccountButton.Name = "RefillAccountButton";
            this.RefillAccountButton.Size = new System.Drawing.Size(460, 52);
            this.RefillAccountButton.TabIndex = 129;
            this.RefillAccountButton.Text = "Пополнить счет";
            this.RefillAccountButton.UseVisualStyleBackColor = false;
            this.RefillAccountButton.Click += new System.EventHandler(this.RefillAccountButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 29);
            this.label2.TabIndex = 129;
            this.label2.Text = "Пополнение мобильного";
            // 
            // PhonePictureBox
            // 
            this.PhonePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PhonePictureBox.Image")));
            this.PhonePictureBox.Location = new System.Drawing.Point(12, 12);
            this.PhonePictureBox.Name = "PhonePictureBox";
            this.PhonePictureBox.Size = new System.Drawing.Size(50, 50);
            this.PhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhonePictureBox.TabIndex = 128;
            this.PhonePictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(55, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 18);
            this.label7.TabIndex = 134;
            this.label7.Text = "Пополнение только на беларусские номера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(109, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 133;
            this.label5.Text = "+375";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(181, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 4);
            this.panel1.TabIndex = 132;
            // 
            // FlagPictureBox
            // 
            this.FlagPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FlagPictureBox.Image")));
            this.FlagPictureBox.Location = new System.Drawing.Point(58, 106);
            this.FlagPictureBox.Name = "FlagPictureBox";
            this.FlagPictureBox.Size = new System.Drawing.Size(45, 41);
            this.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FlagPictureBox.TabIndex = 131;
            this.FlagPictureBox.TabStop = false;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTextBox.ForeColor = System.Drawing.Color.White;
            this.PhoneTextBox.Location = new System.Drawing.Point(181, 113);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(230, 27);
            this.PhoneTextBox.TabIndex = 130;
            // 
            // ComboBoxOperator
            // 
            this.ComboBoxOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ComboBoxOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxOperator.ForeColor = System.Drawing.Color.White;
            this.ComboBoxOperator.FormattingEnabled = true;
            this.ComboBoxOperator.Location = new System.Drawing.Point(58, 191);
            this.ComboBoxOperator.Name = "ComboBoxOperator";
            this.ComboBoxOperator.Size = new System.Drawing.Size(246, 37);
            this.ComboBoxOperator.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(55, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 138;
            this.label6.Text = "Сумма";
            // 
            // SumTextBox
            // 
            this.SumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.ForeColor = System.Drawing.Color.White;
            this.SumTextBox.Location = new System.Drawing.Point(58, 280);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SumTextBox.Size = new System.Drawing.Size(297, 27);
            this.SumTextBox.TabIndex = 136;
            this.SumTextBox.TextChanged += new System.EventHandler(this.SumTextBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(58, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 4);
            this.panel4.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(361, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 139;
            this.label1.Text = "BYN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(55, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 140;
            this.label4.Text = "Номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(54, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 128;
            this.label8.Text = "К оплате:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(54, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 22);
            this.label13.TabIndex = 129;
            this.label13.Text = "Комиссия:";
            // 
            // TotalSumLabel
            // 
            this.TotalSumLabel.AutoSize = true;
            this.TotalSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalSumLabel.ForeColor = System.Drawing.Color.White;
            this.TotalSumLabel.Location = new System.Drawing.Point(272, 370);
            this.TotalSumLabel.Name = "TotalSumLabel";
            this.TotalSumLabel.Size = new System.Drawing.Size(20, 22);
            this.TotalSumLabel.TabIndex = 130;
            this.TotalSumLabel.Text = "0";
            // 
            // CommisionLabel
            // 
            this.CommisionLabel.AutoSize = true;
            this.CommisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommisionLabel.ForeColor = System.Drawing.Color.White;
            this.CommisionLabel.Location = new System.Drawing.Point(272, 336);
            this.CommisionLabel.Name = "CommisionLabel";
            this.CommisionLabel.Size = new System.Drawing.Size(20, 22);
            this.CommisionLabel.TabIndex = 131;
            this.CommisionLabel.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(336, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 22);
            this.label14.TabIndex = 132;
            this.label14.Text = "BYN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(336, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 22);
            this.label15.TabIndex = 133;
            this.label15.Text = "BYN";
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(600, 710);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TotalSumLabel);
            this.Controls.Add(this.CommisionLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ComboBoxOperator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlagPictureBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefillAccountButton);
            this.Controls.Add(this.PhonePictureBox);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PhoneForm_Load);
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhonePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.TextBox CardToTextBox;
        private System.Windows.Forms.TextBox CVVTextBox;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button RefillAccountButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PhonePictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox FlagPictureBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.ComboBox ComboBoxOperator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TotalSumLabel;
        private System.Windows.Forms.Label CommisionLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
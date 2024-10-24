namespace MobileBank.Forms
{
    partial class Credit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credit));
            this.CreditPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.LabelTotalSum = new System.Windows.Forms.Label();
            this.LabelSum = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelToPay = new System.Windows.Forms.Label();
            this.LabelDateToPay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.CreditPercentLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.MonthNumberTextBox = new System.Windows.Forms.TextBox();
            this.SumTrackBar = new System.Windows.Forms.TrackBar();
            this.MonthTrackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonthlyPaymentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CreditPictureBox)).BeginInit();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditPictureBox
            // 
            this.CreditPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CreditPictureBox.Image")));
            this.CreditPictureBox.Location = new System.Drawing.Point(4, 12);
            this.CreditPictureBox.Name = "CreditPictureBox";
            this.CreditPictureBox.Size = new System.Drawing.Size(50, 50);
            this.CreditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CreditPictureBox.TabIndex = 163;
            this.CreditPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 162;
            this.label2.Text = "Кредит";
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
            this.PaymentButton.Location = new System.Drawing.Point(12, 336);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(516, 52);
            this.PaymentButton.TabIndex = 160;
            this.PaymentButton.Text = "Оплатить";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CardPanel.Controls.Add(this.label15);
            this.CardPanel.Controls.Add(this.LabelTotalSum);
            this.CardPanel.Controls.Add(this.LabelSum);
            this.CardPanel.Controls.Add(this.LabelDate);
            this.CardPanel.Controls.Add(this.LabelToPay);
            this.CardPanel.Controls.Add(this.LabelDateToPay);
            this.CardPanel.Controls.Add(this.label7);
            this.CardPanel.Controls.Add(this.label6);
            this.CardPanel.Controls.Add(this.label5);
            this.CardPanel.Controls.Add(this.label4);
            this.CardPanel.Controls.Add(this.label1);
            this.CardPanel.Controls.Add(this.panel5);
            this.CardPanel.Controls.Add(this.NamePanel);
            this.CardPanel.Controls.Add(this.label3);
            this.CardPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardPanel.Location = new System.Drawing.Point(12, 67);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(516, 243);
            this.CardPanel.TabIndex = 161;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(84, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 25);
            this.label15.TabIndex = 172;
            this.label15.Text = "\\";
            // 
            // LabelTotalSum
            // 
            this.LabelTotalSum.AutoSize = true;
            this.LabelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTotalSum.Location = new System.Drawing.Point(101, 119);
            this.LabelTotalSum.Name = "LabelTotalSum";
            this.LabelTotalSum.Size = new System.Drawing.Size(78, 25);
            this.LabelTotalSum.TabIndex = 171;
            this.LabelTotalSum.Text = "100000";
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSum.Location = new System.Drawing.Point(6, 119);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(78, 25);
            this.LabelSum.TabIndex = 170;
            this.LabelSum.Text = "100000";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDate.Location = new System.Drawing.Point(164, 51);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(50, 25);
            this.LabelDate.TabIndex = 169;
            this.LabelDate.Text = "date";
            // 
            // LabelToPay
            // 
            this.LabelToPay.AutoSize = true;
            this.LabelToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelToPay.Location = new System.Drawing.Point(91, 196);
            this.LabelToPay.Name = "LabelToPay";
            this.LabelToPay.Size = new System.Drawing.Size(23, 25);
            this.LabelToPay.TabIndex = 168;
            this.LabelToPay.Text = "0";
            // 
            // LabelDateToPay
            // 
            this.LabelDateToPay.AutoSize = true;
            this.LabelDateToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDateToPay.Location = new System.Drawing.Point(164, 164);
            this.LabelDateToPay.Name = "LabelDateToPay";
            this.LabelDateToPay.Size = new System.Drawing.Size(50, 25);
            this.LabelDateToPay.TabIndex = 167;
            this.LabelDateToPay.Text = "date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(10, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 166;
            this.label7.Text = "К оплате:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(11, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 165;
            this.label6.Text = "Следующая оплата:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(185, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 164;
            this.label5.Text = "BYN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 113;
            this.label4.Text = "Уплачено:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 112;
            this.label1.Text = "Дата оформления:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(11, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(403, 3);
            this.panel5.TabIndex = 111;
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePanel.Location = new System.Drawing.Point(14, 83);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(399, 3);
            this.NamePanel.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 109;
            this.label3.Text = "Мой кредит";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(501, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 27);
            this.CloseButton.TabIndex = 159;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(330, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 22);
            this.label10.TabIndex = 172;
            this.label10.Text = "Ежемесячный платеж";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(330, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 22);
            this.label8.TabIndex = 173;
            this.label8.Text = "Проценты по кредиту";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 176;
            this.label9.Text = "Сумма";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(329, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 29);
            this.label11.TabIndex = 175;
            this.label11.Text = "BYN";
            // 
            // SumTextBox
            // 
            this.SumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.ForeColor = System.Drawing.Color.White;
            this.SumTextBox.Location = new System.Drawing.Point(85, 103);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SumTextBox.Size = new System.Drawing.Size(196, 27);
            this.SumTextBox.TabIndex = 174;
            this.SumTextBox.Click += new System.EventHandler(this.SumTextBox_Click);
            // 
            // CreditPercentLabel
            // 
            this.CreditPercentLabel.AutoSize = true;
            this.CreditPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditPercentLabel.Location = new System.Drawing.Point(329, 177);
            this.CreditPercentLabel.Name = "CreditPercentLabel";
            this.CreditPercentLabel.Size = new System.Drawing.Size(54, 29);
            this.CreditPercentLabel.TabIndex = 177;
            this.CreditPercentLabel.Text = "1 %";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(334, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 35);
            this.button1.TabIndex = 178;
            this.button1.Text = "Оформить кредит";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 22);
            this.label13.TabIndex = 180;
            this.label13.Text = "Количество месяцев:";
            // 
            // MonthNumberTextBox
            // 
            this.MonthNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.MonthNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.MonthNumberTextBox.Location = new System.Drawing.Point(206, 184);
            this.MonthNumberTextBox.Name = "MonthNumberTextBox";
            this.MonthNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MonthNumberTextBox.Size = new System.Drawing.Size(75, 27);
            this.MonthNumberTextBox.TabIndex = 179;
            this.MonthNumberTextBox.Click += new System.EventHandler(this.MonthNumberTextBox_Click);
            // 
            // SumTrackBar
            // 
            this.SumTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SumTrackBar.Location = new System.Drawing.Point(85, 136);
            this.SumTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.SumTrackBar.Maximum = 10000;
            this.SumTrackBar.Minimum = 1;
            this.SumTrackBar.Name = "SumTrackBar";
            this.SumTrackBar.Size = new System.Drawing.Size(196, 56);
            this.SumTrackBar.TabIndex = 181;
            this.SumTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SumTrackBar.Value = 1;
            this.SumTrackBar.Scroll += new System.EventHandler(this.SumTrackBar_Scroll);
            // 
            // MonthTrackBar
            // 
            this.MonthTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonthTrackBar.Location = new System.Drawing.Point(202, 214);
            this.MonthTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.MonthTrackBar.Maximum = 24;
            this.MonthTrackBar.Minimum = 1;
            this.MonthTrackBar.Name = "MonthTrackBar";
            this.MonthTrackBar.Size = new System.Drawing.Size(97, 56);
            this.MonthTrackBar.TabIndex = 182;
            this.MonthTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MonthTrackBar.Value = 1;
            this.MonthTrackBar.Scroll += new System.EventHandler(this.MonthTrackBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(302, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 220);
            this.panel1.TabIndex = 171;
            // 
            // MonthlyPaymentLabel
            // 
            this.MonthlyPaymentLabel.AutoSize = true;
            this.MonthlyPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthlyPaymentLabel.Location = new System.Drawing.Point(398, 101);
            this.MonthlyPaymentLabel.Name = "MonthlyPaymentLabel";
            this.MonthlyPaymentLabel.Size = new System.Drawing.Size(26, 29);
            this.MonthlyPaymentLabel.TabIndex = 183;
            this.MonthlyPaymentLabel.Text = "0";
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(540, 400);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.MonthlyPaymentLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MonthNumberTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MonthTrackBar);
            this.Controls.Add(this.SumTrackBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreditPercentLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CreditPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.CloseButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Credit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Credit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditPictureBox)).EndInit();
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CreditPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelToPay;
        private System.Windows.Forms.Label LabelDateToPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Label CreditPercentLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MonthNumberTextBox;
        private System.Windows.Forms.TrackBar SumTrackBar;
        private System.Windows.Forms.TrackBar MonthTrackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MonthlyPaymentLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LabelTotalSum;
    }
}
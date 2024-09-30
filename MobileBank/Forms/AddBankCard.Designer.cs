namespace MobileBank.Forms
{
    partial class AddBankCard
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
            this.TypeCardLabel = new System.Windows.Forms.Label();
            this.TypeCardComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.PaySystemComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.LastNamePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PaySystemLabel = new System.Windows.Forms.Label();
            this.PINLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownPin = new System.Windows.Forms.NumericUpDown();
            this.AddCardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(220, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 84;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TypeCardLabel
            // 
            this.TypeCardLabel.AutoSize = true;
            this.TypeCardLabel.ForeColor = System.Drawing.Color.White;
            this.TypeCardLabel.Location = new System.Drawing.Point(12, 34);
            this.TypeCardLabel.Name = "TypeCardLabel";
            this.TypeCardLabel.Size = new System.Drawing.Size(74, 16);
            this.TypeCardLabel.TabIndex = 86;
            this.TypeCardLabel.Text = "Тип карты";
            // 
            // TypeCardComboBox
            // 
            this.TypeCardComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TypeCardComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeCardComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeCardComboBox.ForeColor = System.Drawing.Color.White;
            this.TypeCardComboBox.FormattingEnabled = true;
            this.TypeCardComboBox.Items.AddRange(new object[] {
            "Дебетовая",
            "Кредитная"});
            this.TypeCardComboBox.Location = new System.Drawing.Point(18, 53);
            this.TypeCardComboBox.Name = "TypeCardComboBox";
            this.TypeCardComboBox.Size = new System.Drawing.Size(230, 33);
            this.TypeCardComboBox.TabIndex = 107;
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CurrencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrencyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencyComboBox.ForeColor = System.Drawing.Color.White;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "BYN",
            "USD",
            "EUR",
            "RUB"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(18, 118);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(230, 33);
            this.CurrencyComboBox.TabIndex = 108;
            // 
            // PaySystemComboBox
            // 
            this.PaySystemComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PaySystemComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaySystemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaySystemComboBox.ForeColor = System.Drawing.Color.White;
            this.PaySystemComboBox.FormattingEnabled = true;
            this.PaySystemComboBox.Items.AddRange(new object[] {
            "Visa",
            "MasterCard"});
            this.PaySystemComboBox.Location = new System.Drawing.Point(18, 183);
            this.PaySystemComboBox.Name = "PaySystemComboBox";
            this.PaySystemComboBox.Size = new System.Drawing.Size(230, 33);
            this.PaySystemComboBox.TabIndex = 109;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.ForeColor = System.Drawing.Color.White;
            this.CurrencyLabel.Location = new System.Drawing.Point(12, 99);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(57, 16);
            this.CurrencyLabel.TabIndex = 110;
            this.CurrencyLabel.Text = "Валюта";
            // 
            // LastNamePanel
            // 
            this.LastNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.LastNamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNamePanel.Location = new System.Drawing.Point(15, 92);
            this.LastNamePanel.Name = "LastNamePanel";
            this.LastNamePanel.Size = new System.Drawing.Size(227, 4);
            this.LastNamePanel.TabIndex = 111;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(15, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 4);
            this.panel1.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(15, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 4);
            this.panel2.TabIndex = 113;
            // 
            // PaySystemLabel
            // 
            this.PaySystemLabel.AutoSize = true;
            this.PaySystemLabel.ForeColor = System.Drawing.Color.White;
            this.PaySystemLabel.Location = new System.Drawing.Point(15, 164);
            this.PaySystemLabel.Name = "PaySystemLabel";
            this.PaySystemLabel.Size = new System.Drawing.Size(137, 16);
            this.PaySystemLabel.TabIndex = 114;
            this.PaySystemLabel.Text = "Платежная система";
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.ForeColor = System.Drawing.Color.White;
            this.PINLabel.Location = new System.Drawing.Point(15, 229);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(56, 16);
            this.PINLabel.TabIndex = 115;
            this.PINLabel.Text = "PIN-код";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(18, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 4);
            this.panel3.TabIndex = 113;
            // 
            // numericUpDownPin
            // 
            this.numericUpDownPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.numericUpDownPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPin.ForeColor = System.Drawing.Color.White;
            this.numericUpDownPin.Location = new System.Drawing.Point(18, 248);
            this.numericUpDownPin.Name = "numericUpDownPin";
            this.numericUpDownPin.Size = new System.Drawing.Size(230, 34);
            this.numericUpDownPin.TabIndex = 116;
            // 
            // AddCardButton
            // 
            this.AddCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.AddCardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(65)))));
            this.AddCardButton.FlatAppearance.BorderSize = 0;
            this.AddCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCardButton.ForeColor = System.Drawing.Color.White;
            this.AddCardButton.Location = new System.Drawing.Point(35, 306);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(190, 40);
            this.AddCardButton.TabIndex = 117;
            this.AddCardButton.Text = "Создать";
            this.AddCardButton.UseVisualStyleBackColor = false;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // AddBankCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(257, 358);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.numericUpDownPin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.PaySystemLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LastNamePanel);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.PaySystemComboBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.TypeCardComboBox);
            this.Controls.Add(this.TypeCardLabel);
            this.Controls.Add(this.CloseButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBankCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBankCard";           
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddBankCard_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TypeCardLabel;
        private System.Windows.Forms.ComboBox TypeCardComboBox;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox PaySystemComboBox;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Panel LastNamePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PaySystemLabel;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownPin;
        private System.Windows.Forms.Button AddCardButton;
    }
}
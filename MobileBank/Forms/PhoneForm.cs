using MobileBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Globalization;

namespace MobileBank.Forms
{
    public partial class PhoneForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public PhoneForm()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void PhoneForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            PhoneTextBox.Text = DataStorage.phoneNumber;
            CardNumberTextBox.Text = DataStorage.cardNumber;

            var queryChooseOperator = $"select id_service, serviceName from clientServices where serviceType = 'Mobile'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, database.GetConnection());
            database.OpenConnection();
            DataTable operators = new DataTable();
            commandChooseOperator.Fill(operators);
            ComboBoxOperator.DataSource = operators;
            ComboBoxOperator.ValueMember = "id_service";
            ComboBoxOperator.DisplayMember = "serviceName";
            database.CloseConnection();
        }

        private void RefillAccountButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            string tmp = PhoneTextBox.Text;
            string phoneNumberToCheck = String.Concat(tmp[0], tmp[1]);
            string selectedOperator = ComboBoxOperator.GetItemText(ComboBoxOperator.SelectedItem);

            bool numberCheck = false;

            if (selectedOperator == "Velcom")
            {
                if (phoneNumberToCheck != "29" && phoneNumberToCheck != "44")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }
            else if (selectedOperator == "МТС")
            {
                if (phoneNumberToCheck != "33" && phoneNumberToCheck != "29")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }
            else if (selectedOperator == "life:)")
            {
                if (phoneNumberToCheck != "25")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }
            else if (selectedOperator == "Diallog")
            {
                if (phoneNumberToCheck != "29")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }

            if (!numberCheck)
            {
                var phoneNumber = PhoneTextBox.Text;
                double sum = Convert.ToDouble(SumTextBox.Text);
                var cardNumber = CardNumberTextBox.Text;
                var cardCVV = CVVTextBox.Text;
                var cardDate = CardToTextBox.Text;
                var cardCVVCheck = "";
                var cardDateCheck = "";
                double cardBalanceCheck = 0;
                bool error = false;
                string cardCurrency = "";

                double commision = ((Convert.ToDouble(sum) * 2) / 100);
                double totalSum = commision + Convert.ToDouble(sum);

                if (!Regex.IsMatch(PhoneTextBox.Text, "^[0-9]{9}$"))
                {
                    MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, ico);
                    PhoneTextBox.Select();
                    return;
                }

                var queryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{cardNumber}'";
                SqlCommand commandCheckCard = new SqlCommand(queryCheckCard, database.GetConnection());
                database.OpenConnection();
                SqlDataReader reader = commandCheckCard.ExecuteReader();

                while (reader.Read())
                {
                    cardCVVCheck = reader[0].ToString();
                    cardDateCheck = reader[1].ToString();
                    cardBalanceCheck = Convert.ToDouble(reader[2].ToString());
                    cardCurrency = reader[3].ToString();
                }
                reader.Close();

                if (cardCurrency != "BYN")
                {
                    MessageBox.Show("Пополнение мобильного может происходить только в белорусских рублях", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }
                if (cardCVV != cardCVVCheck)
                {
                    MessageBox.Show("Ошибка. Некорректно введен CVV-код", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }
                if (cardDate != cardDateCheck)
                {
                    MessageBox.Show("Ошибка. Некорректно введена дата карты", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }
                if (Convert.ToDouble(sum) < 2.00)
                {
                    MessageBox.Show("Ошибка. Минимальная сумма пополнения 2 BYN", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }
                if (sum > cardBalanceCheck)
                {
                    MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (!error)
                {
                    DataStorage.bankCard = CardNumberTextBox.Text;
                    Validation validation = new Validation();
                    validation.ShowDialog();

                    if (DataStorage.attempts > 0)
                    {
                        DateTime transactionDate = DateTime.Now;
                        var transactionNumber = "p";
                        for (int i = 0; i < 10; i++)
                        {
                            transactionNumber += Convert.ToString(rand.Next(0, 10));
                        }

                        var queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{totalSum}' WHERE bank_card_number = '{cardNumber}'";
                        var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('Пополнение мобильного','+375{phoneNumber}','{transactionDate}','{transactionNumber}','{totalSum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";
                        var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance + '{sum}' where serviceName = '{ComboBoxOperator.GetItemText(ComboBoxOperator.SelectedItem)}' and serviceType = 'Mobile'";

                        SqlCommand command1 = new SqlCommand(queryTransaction1, database.GetConnection());
                        SqlCommand command2 = new SqlCommand(queryTransaction2, database.GetConnection());
                        SqlCommand command3 = new SqlCommand(queryTransaction3, database.GetConnection());

                        database.OpenConnection();
                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                        database.CloseConnection();

                        Close();

                    }


                }
            }

        }
        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SumTextBox.Text == string.Empty)
            {
                SumTextBox.Text = null;
                CommisionLabel.Text = "0";
                TotalSumLabel.Text = "0";
            }
            else
            {
                double sum = Convert.ToDouble(SumTextBox.Text);
                CommisionLabel.Text = Convert.ToString((sum * 2) / 100);
                TotalSumLabel.Text = Convert.ToString((sum * 2) / 100) + sum;
            }
        }
    }
}
using MobileBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class InternetAndTvPayments : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        DataTable table = new DataTable();        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public InternetAndTvPayments()
        {
            InitializeComponent();
        }

        private void InternetAndTvPayments_MouseDown(object sender, MouseEventArgs e)
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

        private void InternetAndTvPayments_Load(object sender, EventArgs e)
        {
            CardNumberTextBox.Text = DataStorage.cardNumber;

            var queryChooseOperator = $"select id_service, serviceName from clientServices where serviceType = 'Internet'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, database.GetConnection());
            database.OpenConnection();
            DataTable operators = new DataTable();
            commandChooseOperator.Fill(operators);
            ComboBoxInternetAndTvPayment.DataSource = operators;
            ComboBoxInternetAndTvPayment.ValueMember = "id_service";
            ComboBoxInternetAndTvPayment.DisplayMember = "serviceName";
            database.CloseConnection();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            var personalAccount = PersonalAccountTextBox.Text;
            double sum = Convert.ToDouble(SumTextBox.Text);
            var cardNumber = CardNumberTextBox.Text;
            var cardCVV = CVVTextBox.Text;
            var cardDate = CardToTextBox.Text;
            var cardCVVCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;
            string cardCurrency = "";

            if (!Regex.IsMatch(PersonalAccountTextBox.Text, "^[0-9]{10}$"))
            {
                MessageBox.Show("Введите корректно ваш номер лицевого счета", caption, btn, ico);
                PersonalAccountTextBox.Select();
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
                MessageBox.Show("Оплата Интенет и ТВ услуг можно проводить только в белорусских рублях", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    var queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum.ToString(CultureInfo.InvariantCulture)}' WHERE bank_card_number = '{cardNumber}'";
                    var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('Оплата Интернет и ТВ', '{ComboBoxInternetAndTvPayment.GetItemText(ComboBoxInternetAndTvPayment.SelectedItem)}','{transactionDate}','{transactionNumber}','{sum.ToString(CultureInfo.InvariantCulture)}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";
                    var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance + '{sum.ToString(CultureInfo.InvariantCulture)}' where serviceName = '{ComboBoxInternetAndTvPayment.GetItemText(ComboBoxInternetAndTvPayment.SelectedItem)}' and serviceType = 'Internet'";
                    var queryTransaction4 = $"insert into clientPersonalAccount(personal_account,id_service,id_client) values('{PersonalAccountTextBox.Text}',(select id_service from clientServices where serviceName = '{ComboBoxInternetAndTvPayment.GetItemText(ComboBoxInternetAndTvPayment.SelectedItem)}'),'{DataStorage.idClient}')";

                    SqlCommand command1 = new SqlCommand(queryTransaction1, database.GetConnection());
                    SqlCommand command2 = new SqlCommand(queryTransaction2, database.GetConnection());
                    SqlCommand command3 = new SqlCommand(queryTransaction3, database.GetConnection());
                    SqlCommand command4 = new SqlCommand(queryTransaction4, database.GetConnection());

                    database.OpenConnection();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command4.ExecuteNonQuery();

                    database.CloseConnection();

                    Close();
                }
            }
        }
    }
}

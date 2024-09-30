using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MobileBank.Classes;

namespace MobileBank.Forms
{
    public partial class SendToForm : Form
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

        public SendToForm()
        {
            InitializeComponent();
        }

        private void SendToForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SendToForm_Load(object sender, EventArgs e)
        {
            CardTextBox.Text = DataStorage.cardNumber;
            CardDestinationTextBox.Text = DataStorage.bankCard;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // курс валюты в BYN
            double dolar = 3.27;
            double euro = 3.64;
            double rub = 0.035;

            var cardNumber = CardTextBox.Text;
            var cardCVV = CVVTextBox.Text;
            var cardDate = CardToTextBox.Text;
            var destinationCard = CardDestinationTextBox.Text;
            double sum = Convert.ToDouble(SumTextBox.Text);
            var cardCurrency = "";
            var cardCurrency2 = "";
            var cardCVVCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;

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

            var queryCheckCardNumber = $"select id_bank_card, bank_card_currency from bank_card where bank_card_number = '{destinationCard}'";
            SqlCommand commandCheckCardNumber = new SqlCommand(queryCheckCardNumber, database.GetConnection());

            adapter.SelectCommand = commandCheckCardNumber;
            adapter.Fill(table);
            SqlDataReader reader1 = commandCheckCardNumber.ExecuteReader();
            while (reader1.Read())
            {
                cardCurrency2 = reader1[1].ToString();
            }
            reader1.Close();

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Ошибка. Некорректные данне карты получателя", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (Convert.ToDouble(sum) < 1.00)
            {
                MessageBox.Show("Ошибка. Минимальная сумма перевода 1.00 BYN", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardNumber == destinationCard)
            {
                MessageBox.Show("Ошибка. Вы не можете перевести средства на эту карту", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (!error)
            {
                DataStorage.bankCard = CardTextBox.Text;
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
                    var queryTransaction1 = $"";
                    var queryTransaction2 = $"";

                    if (cardCurrency == "BYN" && cardCurrency2 == "USD")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum / dolar}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "BYN" && cardCurrency2 == "EUR")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum / euro}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "BYN" && cardCurrency2 == "RUB")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum / rub}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "USD" && cardCurrency2 == "BYN")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * dolar}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "EUR" && cardCurrency2 == "BYN")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * euro}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "RUB" && cardCurrency2 == "BYN")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * rub}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "USD" && cardCurrency2 == "EUR")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (dolar / euro)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "EUR" && cardCurrency2 == "USD")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (euro / dolar)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "USD" && cardCurrency2 == "RUB")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (dolar / rub)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "RUB" && cardCurrency2 == "USD")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (rub / dolar)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "EUR" && cardCurrency2 == "RUB")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (euro / rub)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "RUB" && cardCurrency2 == "EUR")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (rub / euro)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "RUB" && cardCurrency2 == "USD")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum *(rub / dolar)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "USD" && cardCurrency2 == "RUB")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (dolar / rub)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "EUR" && cardCurrency2 == "RUB")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (euro / rub)}' WHERE bank_card_number = '{destinationCard}'";
                    }
                    else if (cardCurrency == "RUB" && cardCurrency2 == "EUR")
                    {
                        queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{sum}' WHERE bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sum * (rub / euro)}' WHERE bank_card_number = '{destinationCard}'";
                    }

                    //var queryTransaction3 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value)";
                    var command1 = new SqlCommand(queryTransaction1, database.GetConnection());
                    var command2 = new SqlCommand(queryTransaction2, database.GetConnection());
                    //var command3 = new SqlCommand(queryTransaction3, database.GetConnection());
                    database.OpenConnection();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    //command3.ExecuteNonQuery();
                    database.CloseConnection();

                    Close();
                }
            }
        }
    }
}

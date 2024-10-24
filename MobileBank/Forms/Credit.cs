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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class Credit : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        Validation validation = new Validation();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Credit()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void Credit_MouseDown(object sender, MouseEventArgs e)
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

        private void Credit_Load(object sender, EventArgs e)
        {
            SumTextBox.Text = SumTrackBar.Value.ToString();
            MonthNumberTextBox.Text = MonthTrackBar.Value.ToString();
            CardPanel.Visible = false;
            PaymentButton.Visible = false;

            string totalSum = "";
            string sum = "";
            DateTime date = DateTime.MinValue;
            string idCredit = "";

            double creditTotalSumCheck = 0;
            double creditSumToCheck = 0;

            var queryCheckCreditStatus = $"SELECT credit_total_sum, credit_sum FROM credits WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{DataStorage.cardNumber}')";
            SqlCommand commandCheckCreditStatus = new SqlCommand(queryCheckCreditStatus, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader3 = commandCheckCreditStatus.ExecuteReader();
            while (reader3.Read())
            {
                // Проверяем на NULL перед конвертацией
                creditTotalSumCheck = reader3.IsDBNull(0) ? 0 : Convert.ToDouble(reader3[0]);
                creditSumToCheck = reader3.IsDBNull(1) ? 0 : Convert.ToDouble(reader3[1]);
            }
            reader3.Close();

            // Проверка, если кредит погашен
            if (creditSumToCheck >= creditTotalSumCheck)
            {
                var queryDeleteCredit = $"DELETE FROM credits WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number ='{DataStorage.cardNumber}')";
                SqlCommand commandDeleteCredit = new SqlCommand(queryDeleteCredit, database.GetConnection());
                commandDeleteCredit.ExecuteNonQuery();
            }

            var querySelectIdCard = $"SELECT credits.id_bank_card, credits.credit_total_sum, credits.credit_sum, credits.credit_date, credits.id_credit " +
                                    $"FROM credits " +
                                    $"INNER JOIN bank_card ON credits.id_bank_card = bank_card.id_bank_card " +
                                    $"WHERE bank_card.bank_card_number = '{DataStorage.cardNumber}'";
            SqlCommand commandSelectCredit = new SqlCommand(querySelectIdCard, database.GetConnection());
            SqlDataReader reader = commandSelectCredit.ExecuteReader();
            while (reader.Read())
            {
                totalSum = reader.IsDBNull(1) ? "0" : reader[1].ToString();
                sum = reader.IsDBNull(2) ? "0" : reader[2].ToString();
                date = reader.IsDBNull(3) ? DateTime.MinValue : Convert.ToDateTime(reader[3].ToString());
                idCredit = reader.IsDBNull(4) ? "" : reader[4].ToString();
            }
            reader.Close();

            // Используем параметризованный запрос для большей безопасности
            SqlCommand commandSelectIdCard = new SqlCommand(querySelectIdCard, database.GetConnection());
            adapter.SelectCommand = commandSelectIdCard;
            adapter.Fill(table);

            // Проверяем, есть ли кредит
            if (table.Rows.Count > 0)
            {
                CardPanel.Visible = true;
                PaymentButton.Visible = true;

                LabelSum.Text = Math.Round(Convert.ToDouble(sum), 2).ToString();
                LabelTotalSum.Text = Math.Round(Convert.ToDouble(totalSum), 2).ToString();
                LabelDate.Text = date != DateTime.MinValue ? date.ToShortDateString() : "Не указана";

                double toPaySum = 0;
                DateTime dateRepay = DateTime.MinValue;

                var querySelectRepayment = $"SELECT repayment_date, repayment_sum FROM credits WHERE id_credit = '{idCredit}'";
                SqlCommand commandSelectRepayment = new SqlCommand(querySelectRepayment, database.GetConnection());
                SqlDataReader reader1 = commandSelectRepayment.ExecuteReader();
                while (reader1.Read())
                {
                    // Проверка на NULL для дат и сумм
                    dateRepay = reader1.IsDBNull(0) ? DateTime.MinValue : Convert.ToDateTime(reader1[0].ToString());
                    toPaySum = reader1.IsDBNull(1) ? 0 : Convert.ToDouble(reader1[1].ToString());
                }
                reader1.Close();
                database.CloseConnection();

                LabelToPay.Text = Math.Round(toPaySum, 2).ToString();
                LabelDateToPay.Text = dateRepay != DateTime.MinValue ? dateRepay.ToShortDateString() : "Не указана";
            }
        }


        private void CalculateCredit()
        {
            double monthlyRate = 0.01;
            double sum = Convert.ToDouble(SumTextBox.Text);
            int numberOfMonths = Convert.ToInt32(MonthNumberTextBox.Text);
            double result = sum * (monthlyRate + (monthlyRate / (Math.Pow(1 + monthlyRate, numberOfMonths) - 1)));
            MonthlyPaymentLabel.Text = Math.Round(result, 2).ToString();
        }

        private void SumTrackBar_Scroll(object sender, EventArgs e)
        {
            SumTextBox.Text = SumTrackBar.Value.ToString();            
        }

        private void SumTextBox_Click(object sender, EventArgs e)
        {
            SumTrackBar.Value = Convert.ToInt32(SumTextBox.Text);
            CalculateCredit();
        }

        private void MonthTrackBar_Scroll(object sender, EventArgs e)
        {
            MonthNumberTextBox.Text = MonthTrackBar.Value.ToString();
        }

        private void MonthNumberTextBox_Click(object sender, EventArgs e)
        {
            MonthTrackBar.Value = Convert.ToInt32(MonthNumberTextBox.Text);
            CalculateCredit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SumTrackBar.Value = Convert.ToInt32(SumTextBox.Text);
            MonthTrackBar.Value = Convert.ToInt32(MonthNumberTextBox.Text);
            CalculateCredit();

            DataStorage.bankCard = DataStorage.cardNumber;
            validation.ShowDialog();

            if (DataStorage.attempts > 0)
            {
                double totalSum = Convert.ToDouble(MonthlyPaymentLabel.Text) * Convert.ToDouble(MonthNumberTextBox.Text);
                DateTime creditDate = DateTime.Now;
                DateTime repaymentDate = creditDate.AddMonths(1);
                double payment = Convert.ToDouble(MonthlyPaymentLabel.Text);

                database.OpenConnection();

                // Параметризованный запрос для вставки кредита
                var queryCredit = "INSERT INTO credits (credit_total_sum, credit_sum, credit_date, id_bank_card) " +
                                  "VALUES (@totalSum, 0, @creditDate, (SELECT id_bank_card FROM bank_card WHERE bank_card_number = @cardNumber))";

                using (SqlCommand command1 = new SqlCommand(queryCredit, database.GetConnection()))
                {
                    command1.Parameters.AddWithValue("@totalSum", totalSum);
                    command1.Parameters.AddWithValue("@creditDate", creditDate);
                    command1.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);

                    command1.ExecuteNonQuery();
                }

                // Получение ID кредита
                string idCredit = "";
                var querySelectId = "SELECT id_credit FROM credits WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = @cardNumber)";

                using (SqlCommand command3 = new SqlCommand(querySelectId, database.GetConnection()))
                {
                    command3.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);

                    using (SqlDataReader reader = command3.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idCredit = reader[0].ToString();
                        }
                    }
                }

                // Обновление информации о выплатах
                var queryRepayment = "UPDATE credits SET repayment_date = @repaymentDate, repayment_sum = @payment WHERE id_credit = @idCredit";
                var queryCardUpdate = "UPDATE bank_card SET bank_card_balance = bank_card_balance + @sum WHERE bank_card_number = @cardNumber";

                using (SqlCommand command2 = new SqlCommand(queryRepayment, database.GetConnection()))
                {
                    command2.Parameters.AddWithValue("@repaymentDate", repaymentDate);
                    command2.Parameters.AddWithValue("@payment", payment);
                    command2.Parameters.AddWithValue("@idCredit", idCredit);
                    command2.ExecuteNonQuery();
                }

                using (SqlCommand command4 = new SqlCommand(queryCardUpdate, database.GetConnection()))
                {
                    command4.Parameters.AddWithValue("@sum", SumTextBox.Text);
                    command4.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);
                    command4.ExecuteNonQuery();
                }

                MessageBox.Show("Кредит оформлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.CloseConnection();

                // Обновление данных на форме
                UpdateCreditInfo(idCredit);
            }
        }

        // Метод для обновления информации о кредите на форме
        private void UpdateCreditInfo(string idCredit)
        {
            DateTime toPayDate = DateTime.MinValue;
            DateTime creditTakeDate = DateTime.MinValue;
            double creditSum = 0;
            double creditTotalSum = 0;
            double creditToPaySum = 0;

            var querySelectRepayment = $"SELECT credit_date, credit_sum, credit_total_sum, repayment_date, repayment_sum FROM credits WHERE id_credit = @idCredit";
            using (SqlCommand commandSelectRepayment = new SqlCommand(querySelectRepayment, database.GetConnection()))
            {
                commandSelectRepayment.Parameters.AddWithValue("@idCredit", idCredit);
                database.OpenConnection();

                using (SqlDataReader readerUpdate = commandSelectRepayment.ExecuteReader())
                {
                    while (readerUpdate.Read())
                    {
                        creditTakeDate = readerUpdate.GetDateTime(0);
                        creditSum = readerUpdate.IsDBNull(1) ? 0.0 : Convert.ToDouble(readerUpdate[1]);  
                        creditTotalSum = readerUpdate.IsDBNull(2) ? 0.0 : Convert.ToDouble(readerUpdate[2]);
                        toPayDate = readerUpdate.GetDateTime(3);
                        creditToPaySum = readerUpdate.IsDBNull(4) ? 0.0 : Convert.ToDouble(readerUpdate[4]);
                    }
                }
                database.CloseConnection();
            }

            // Обновление меток на форме
            LabelDate.Text = creditTakeDate.ToShortDateString();
            LabelSum.Text = Math.Round(creditSum, 2).ToString();
            LabelTotalSum.Text = Math.Round(creditTotalSum, 2).ToString();
            LabelDateToPay.Text = toPayDate.ToShortDateString();
            LabelToPay.Text = Math.Round(creditToPaySum, 2).ToString();

            PaymentButton.Visible = true;
            CardPanel.Visible = true;
        }


        private void PaymentButton_Click(object sender, EventArgs e)
        {
            DateTime toPayDate = Convert.ToDateTime(LabelDateToPay.Text);
            toPayDate = toPayDate.AddMonths(1);
            double sumToPay = Convert.ToDouble(LabelToPay.Text);
            double toPaySum = 0;
            DateTime dateRepay = DateTime.MinValue;
            bool error = false;

            database.OpenConnection();

            // Проверка баланса карты
            double cardBalanceCheck = 0;
            var queryCheckCard = $"SELECT bank_card_balance FROM bank_card WHERE bank_card_number = @cardNumber";
            using (SqlCommand commandCheckCard = new SqlCommand(queryCheckCard, database.GetConnection()))
            {
                commandCheckCard.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);
                SqlDataReader reader = commandCheckCard.ExecuteReader();
                if (reader.Read())
                {
                    cardBalanceCheck = Convert.ToDouble(reader[0].ToString());
                }
                reader.Close();
            }

            if (Convert.ToDouble(LabelSum.Text) >= Convert.ToDouble(LabelTotalSum.Text))
            {
                MessageBox.Show("Кредит погашен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            double paymentSum = Convert.ToDouble(LabelToPay.Text);
            if (paymentSum > cardBalanceCheck)
            {
                MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (!error)
            {
                var queryPayCredit = "UPDATE credits SET repayment_date = @repaymentDate, credit_sum = credit_sum + repayment_sum WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = @cardNumber)";
                var queryPay = "UPDATE bank_card SET bank_card_balance = bank_card_balance - @sumToPay WHERE bank_card_number = @cardNumber";

                using (SqlCommand command = new SqlCommand(queryPayCredit, database.GetConnection()))
                {
                    command.Parameters.AddWithValue("@repaymentDate", toPayDate);
                    command.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command1 = new SqlCommand(queryPay, database.GetConnection()))
                {
                    command1.Parameters.AddWithValue("@sumToPay", sumToPay);
                    command1.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);
                    command1.ExecuteNonQuery();
                }

                // Вставка транзакции
                DateTime transactionDate = DateTime.Now;
                var transactionNumber = "p";
                for (int i = 0; i < 10; i++)
                {
                    transactionNumber += Convert.ToString(rand.Next(0, 10));
                }
                var queryTransaction = "INSERT INTO transactions (transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) " +
                                       "VALUES ('Кредит', 'Погашение кредита', @transactionDate, @transactionNumber, @sumToPay, (SELECT id_bank_card FROM bank_card WHERE bank_card_number = @cardNumber))";

                using (SqlCommand command2 = new SqlCommand(queryTransaction, database.GetConnection()))
                {
                    command2.Parameters.AddWithValue("@transactionDate", transactionDate);
                    command2.Parameters.AddWithValue("@transactionNumber", transactionNumber);
                    command2.Parameters.AddWithValue("@sumToPay", sumToPay.ToString(CultureInfo.InvariantCulture));
                    command2.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);
                    command2.ExecuteNonQuery();
                }

                // Обновление данных на форме
                var querySelectRepayment = "SELECT repayment_date, credit_sum FROM credits WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = @cardNumber)";
                using (SqlCommand commandSelectRepayment = new SqlCommand(querySelectRepayment, database.GetConnection()))
                {
                    commandSelectRepayment.Parameters.AddWithValue("@cardNumber", DataStorage.cardNumber);
                    using (SqlDataReader reader1 = commandSelectRepayment.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            dateRepay = reader1.GetDateTime(0);
                            toPaySum = reader1.IsDBNull(1) ? 0.0 : Convert.ToDouble(reader1[1]);
                        }
                    }
                }

                LabelSum.Text = Math.Round(toPaySum, 2).ToString();
                LabelDateToPay.Text = dateRepay.ToShortDateString();
            }

            database.CloseConnection();
        }
    }
}

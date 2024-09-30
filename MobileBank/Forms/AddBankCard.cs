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
    public partial class AddBankCard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        DataBaseConnection database = new DataBaseConnection();
        // для cvv кода
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public AddBankCard()
        {
            InitializeComponent();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            var cardType = TypeCardComboBox.GetItemText(TypeCardComboBox.SelectedItem);
            var currency = CurrencyComboBox.GetItemText(CurrencyComboBox.SelectedItem);
            var paymentSystem = PaySystemComboBox.GetItemText(PaySystemComboBox.SelectedItem);
            var cardNumber = "";
            var cardPin = numericUpDownPin.Value;
            var cvvCode = "";
            bool isCardFree = false;
            DateTime dateTime = DateTime.Now;
            var cardDate = dateTime.AddYears(4);

            for (int i = 0; i < 3; i++)
            {
                cvvCode += Convert.ToString(rand.Next(0, 10));
            }
            do
            {
                if (paymentSystem == "Visa")
                {
                    cardNumber += "4";
                }
                else
                {
                    cardNumber += "5";
                }
                for (int i = 0; i < 15; i++)
                {
                    cardNumber += Convert.ToString(rand.Next(0, 10));
                }

                var queryCheckCardNumber = $"select * from bank_card where bank_card_number = '{cardNumber}'";

                SqlCommand command = new SqlCommand(queryCheckCardNumber, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    isCardFree = true;
                }

            } while (!isCardFree);

            var queryAddNewCard = $"insert into bank_card (bank_card_type, bank_card_number, bank_card_cvv_code, bank_card_currency, bank_card_paymentSystem, bank_card_date, id_client , bank_card_pin) values ('{cardType}', '{cardNumber}', '{cvvCode}', '{currency}', '{paymentSystem}','{cardDate}' ,'{DataStorage.idClient}' ,'{cardPin}')";

            SqlCommand commandAddNewCard = new SqlCommand(queryAddNewCard, database.GetConnection());
            database.OpenConnection();
            commandAddNewCard.ExecuteNonQuery();
            database.CloseConnection();

            MessageBox.Show("Карта успешно создана", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void AddBankCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

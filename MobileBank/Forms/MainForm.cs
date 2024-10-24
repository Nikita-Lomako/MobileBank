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

namespace MobileBank.Forms
{
    public partial class MainForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        public MainForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBankCard addBankCard = new AddBankCard();
            addBankCard.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            LabelCardNumber.Text = "";
            // невидимость для карт пока
            MasterCardPictureBox.Visible = false;
            VisaPictureBox.Visible = false;

            var queryMyCards = $"select id_bank_card, bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
            SqlDataAdapter adapterMyCards = new SqlDataAdapter(queryMyCards,database.GetConnection());
            database.OpenConnection();
            DataTable cards = new DataTable();
            adapterMyCards.Fill(cards);
            CardsComboBox.DataSource = cards;
            CardsComboBox.ValueMember = "id_bank_card";
            CardsComboBox.DisplayMember = "bank_card_number";
            database.CloseConnection();

            SelectBankCard();
            
        }

        private void SelectBankCard()
        {
            LabelCardNumber.Text = "";
            string paymentSystem = "";
            string querySelectedCard = $"select bank_card_number, bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_paymentSystem, bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{CardsComboBox.GetItemText(CardsComboBox.SelectedItem)}'";
            SqlCommand command = new SqlCommand(querySelectedCard,database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var cardNumber = reader[0].ToString();

                int tmp = 0;
                int tmp1 = 4;
                for (int m = 0; m < 4; m++)
                {
                    for (int n = tmp; n < tmp1; n++)
                    {
                        LabelCardNumber.Text += cardNumber[n].ToString();
                    }
                    LabelCardNumber.Text += " ";
                    tmp += 4;
                    tmp1 += 4;
                }

                LabelCardCVV.Text = reader[1].ToString();
                LabelCardTo.Text = reader[2].ToString();
                paymentSystem = reader[3].ToString();
                BalanceLabel.Text = Math.Round(Convert.ToDouble(reader[4]),2).ToString();
                CurrencyLabel.Text = reader[5].ToString();
                DataStorage.cardCVV = LabelCardCVV.Text;
                LabelCardCVV.Text = "***";
            }
            reader.Close();

            if(paymentSystem == "Visa")
            {
                VisaPictureBox.Visible = true;
                MasterCardPictureBox.Visible = false;
            }
            else
            {
                MasterCardPictureBox.Visible = true;
                VisaPictureBox.Visible = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelCardCVV_Click(object sender, EventArgs e)
        {
            if(LabelCardCVV.Text == "***")
            {
                LabelCardCVV.Text = DataStorage.cardCVV;
            }
            else
            {
                LabelCardCVV.Text = "***";
            }
        }

        private void UploadPictureBox_Click(object sender, EventArgs e)
        {
            var queryMyCards = $"select id_bank_card, bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
            SqlDataAdapter commandsMyCards = new SqlDataAdapter(queryMyCards, database.GetConnection());
            database.OpenConnection();
            DataTable cards = new DataTable();
            commandsMyCards.Fill(cards);
            CardsComboBox.DataSource = cards;
            CardsComboBox.ValueMember = "id_bank_card";
            CardsComboBox.DisplayMember = "bank_card_number";
            database.CloseConnection();

            SelectBankCard();
        }

        private void CardsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelCardNumber.Text = "";
            SelectBankCard();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            SendToForm sendToForm = new SendToForm();
            DataStorage.bankCard = CardTextBox.Text;
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            CardsComboBox.Text = "";
            sendToForm.ShowDialog();
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void TransactionsPictureBox_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        private void PhoneButton_Click(object sender, EventArgs e)
        {
            PhoneForm phoneForm = new PhoneForm();
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            DataStorage.phoneNumber = PhoneTextBox.Text;
            PhoneTextBox.Text = "";
            phoneForm.Show();
        }

        private void CommunalButton_Click(object sender, EventArgs e)
        {
            CommunalPayments communalPayments = new CommunalPayments();
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            communalPayments.Show();
        }

        private void InternetButton_Click(object sender, EventArgs e)
        {
            InternetAndTvPayments internetAndTvPayments = new InternetAndTvPayments();
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            internetAndTvPayments.Show();
        }

        private void MilitaryButton_Click(object sender, EventArgs e)
        {
            ArmyHelp armyHelp = new ArmyHelp();
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            armyHelp.Show();
        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            var cardCurrency = "";
            var queryCheckCurrency = $"select bank_card_currency from bank_card where bank_card_number = '{DataStorage.cardNumber}'";
            SqlCommand commandCheckCurrency = new SqlCommand(queryCheckCurrency, database.GetConnection());
            SqlDataReader reader = commandCheckCurrency.ExecuteReader();
            while (reader.Read())
            {
                cardCurrency = reader[0].ToString();
            }
            reader.Close();
            if (cardCurrency == "BYN")
            {
                Credit credit = new Credit();
                credit.Show();
            }
            else            
                MessageBox.Show("Операции с кредитом могут проводиться только в белорусских рублях", "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            
        }
    }
}

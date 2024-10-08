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
    public partial class LoginForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        public LoginForm()
        {
            InitializeComponent();

            // Установка маскировки паролей по умолчанию
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PhoneNumbertextBox.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PhoneNumbertextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                var querySelectClient = $"SELECT * FROM client WHERE client_phone_number = '{PhoneNumbertextBox.Text}' AND client_password = '{PasswordTextBox.Text}'";
                var queryGetId = $"SELECT id_client FROM client WHERE client_phone_number = '{PhoneNumbertextBox.Text}'";
                var commandGetId = new SqlCommand(queryGetId, dataBase.GetConnection());

                dataBase.OpenConnection();
                SqlDataReader reader = commandGetId.ExecuteReader();
                while (reader.Read())
                {
                    DataStorage.idClient = reader[0].ToString();
                }
                reader.Close();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand(querySelectClient,dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    PhoneNumbertextBox.Clear();
                    PasswordTextBox.Clear();
                    ShowPasswordCheckBox.Checked = false;

                    Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Имя пользователя или пароль неверны. Попробуйте еще раз!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    PhoneNumbertextBox.Focus();
                    PhoneNumbertextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PhoneNumbertextBox.Select();
            }
        }
    }
}

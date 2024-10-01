using MobileBank.Classes;
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

namespace MobileBank.Forms
{
    public partial class UserForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public UserForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }       

        private void RefreshData()
        {
            var queryPIB = $"select concat(client_last_name, ' ', client_first_name, ' ', client_middle_name), client_phone_number, client_email from client where id_client = '{DataStorage.idClient}'";
            SqlCommand commandPIB = new SqlCommand(queryPIB, database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = commandPIB.ExecuteReader();
            while (reader.Read())
            {
                FIOLabel.Text += reader[0].ToString();
                PhoneLabel.Text += reader[1].ToString();
                MailLabel.Text += reader[2].ToString();
            }
            reader.Close();
        }

        private void ClearFields()
        {
            FIOLabel.Text = string.Empty;
            PhoneLabel.Text = string.Empty;
            MailLabel.Text = string.Empty;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            RefreshData();
        }

        private void ChangePhoneButton_Click(object sender, EventArgs e)
        {
            ChangePhoneNumber changePhoneNumber = new ChangePhoneNumber();
            changePhoneNumber.Show();
        }

        private void ChangeMailButton_Click(object sender, EventArgs e)
        {
            ChangeEmail changeEmail = new ChangeEmail();
            changeEmail.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

    }
}

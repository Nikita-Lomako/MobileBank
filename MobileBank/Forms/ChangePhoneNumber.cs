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
using System.Text.RegularExpressions;

namespace MobileBank.Forms
{
    public partial class ChangePhoneNumber : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ChangePhoneNumber()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePhoneNumber_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ChangePhoneButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if (!Regex.IsMatch(NumberTextBox.Text, "^[+][3][7][5][0-9]{8,13}$"))
            {
                MessageBox.Show("Пожалуйста, введите новый номер телефона",caption,btn,ico);
                NumberTextBox.Select();
                return;
            }

            var phoneNumber = NumberTextBox.Text;
            var changeNumQuery = $"update client set client_phone_number = '{phoneNumber}' where id_client = '{DataStorage.idClient}'";
            var command = new SqlCommand(changeNumQuery,database.GetConnection());
            database.OpenConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Номер телефона успешно изменен!");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            database.CloseConnection();
        }
    }
}

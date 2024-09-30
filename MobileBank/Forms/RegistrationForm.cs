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
using System.Text.RegularExpressions;

namespace MobileBank.Forms
{
    public partial class RegistrationForm : Form
    {

        DataBaseConnection dataBase = new DataBaseConnection();

        public RegistrationForm()
        {
            InitializeComponent();

            // Установка маскировки паролей по умолчанию
            PasswordTextBox.UseSystemPasswordChar = true;
            RepitPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LastNameTextBox.Select();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            string caption = "Дата сохранения";
            // проверка строки на русские символы от А до Я и от а до я, также проверка что первая буква большая а остальные маленькие
            if (!Regex.IsMatch(LastNameTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Пожалуйста, введите фамилию повторно!", caption, btn, icon);
                LastNameTextBox.Select();
            }
            if (!Regex.IsMatch(NameTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Пожалуйста, введите имя повторно!", caption, btn, icon);
                NameTextBox.Select();
            }
            if (!Regex.IsMatch(MiddleNameTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Пожалуйста, введите отчество повторно!", caption, btn, icon);
                MiddleNameTextBox.Select();
            }
            // проверка на выбор пола(выбрал ли)
            if (string.IsNullOrEmpty(GenderComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Пожалуйста выберите пол", caption, btn, icon);
                GenderComboBox.Select();
                return;
            }
            // проверка на валидность пароля не менее 8-ми символов
            if (!Regex.IsMatch(PasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите  пароль", caption, btn, icon);
                PasswordTextBox.Select();
                return;
            }
            if (!Regex.IsMatch(RepitPasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите подтверждение пароля", caption, btn, icon);
                RepitPasswordTextBox.Select();
                return;
            }
            // проверка на соответствия введенного и подтверждающего пароля
            if (PasswordTextBox.Text != RepitPasswordTextBox.Text)
            {
                MessageBox.Show("Ваш пароль и пароль подтверждения не совпадают", caption, btn, icon);
                RepitPasswordTextBox.Select();
                return;
            }
            // какие-то буквы\@\какие-то буквы\.\какие-то буквы(2 или 3)
            if (!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста, введите вашу почту", caption, btn, icon);
                EmailTextBox.Select();
                return;
            }
            // +375 и другие цифры номера, символов вместе с + от 12 // здесь задаются валидные номера
            if (!Regex.IsMatch(PhoneNumberTextBox.Text, "^[+][3][7][5][0-9]{9,13}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, icon);
                PhoneNumberTextBox.Select();
                return;
            }

            string yourSQL = "SELECT client_phone_number FROM client WHERE client_phone_number = '" + PhoneNumberTextBox.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(yourSQL, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Номер телефона уже существует. Невозможно зарегестрировать аккаунт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhoneNumberTextBox.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Вы хотите сохранить запись?","Сохранение данных",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO client (client_last_name, client_first_name, client_middle_name, client_gender,client_password, client_email, client_phone_number)";
                mySQL += "VALUES ('" + LastNameTextBox.Text + "','" + NameTextBox.Text + "','" + MiddleNameTextBox.Text + "',";
                mySQL += "'" + GenderComboBox.SelectedItem.ToString() + "','" + PasswordTextBox.Text + "','" + EmailTextBox.Text + "','" + PhoneNumberTextBox.Text + "')";

                dataBase.OpenConnection();
                SqlCommand commandAddNewUser = new SqlCommand(mySQL,dataBase.GetConnection());
                commandAddNewUser.ExecuteNonQuery();

                MessageBox.Show("Запись успешно сохранена","Данные сохранены", MessageBoxButtons.OK,MessageBoxIcon.Information);

                ClearControls();
                dataBase.CloseConnection();
                Close();
            }
        }
        // метод очищает поля регистрации
        private void ClearControls()
        {
            foreach(TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.SelectedItem = null;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Select();
            ClearControls();
        }
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                RepitPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                RepitPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

    }
}

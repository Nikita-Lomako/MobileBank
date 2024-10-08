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
    public partial class History : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public History()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            var querySelectTransactions = $"select transaction_type, transaction_destination, transaction_date,transaction_number,transaction_value from transactions inner join bank_card on transactions.id_bank_card = bank_card.id_bank_card inner join client on client.id_client = bank_card.id_client where client.id_client = '{DataStorage.idClient}'";
            SqlCommand command = new SqlCommand(querySelectTransactions,database.GetConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                TransactionsListView.Items.Add(item);
            }
            reader.Close();

            TransactionsListView.Sort();
        }
    }
}

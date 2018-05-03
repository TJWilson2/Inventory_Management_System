using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Inventory_Management_System
{
    public partial class Renew_Extend_Loan : Form
    {
        public Renew_Extend_Loan()
        {
            InitializeComponent();
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Renew_Extend_Loan_Load(object sender, EventArgs e)
        {
            SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

            try
            {
                mConn.Open();

                using (var adapter = new SQLiteDataAdapter("select Item, [Due Date] from Item_Table WHERE On_Loan=1 AND [Loaned To]='" + Variables.currentLoggedInUser + "' ORDER BY [Due Date] asc;", mConn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    this.dataGridView1.DataSource = table;
                }

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dataGridView1.CurrentCell.Selected = false;
            }
            catch (SQLiteException Ex)
            {
                MessageBox.Show("Exception: " + Ex);
            }

            mConn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

            try
            {

                Hide();
                Calendar frm1 = new Calendar();
                frm1.ShowDialog();
                frm1 = null;

                Show();

                var confirmResult = MessageBox.Show("Please confirm you would like to renew/extend the loan of " + dataGridView1.SelectedCells[0].Value + " until " + Variables.userSelectedDate, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    mConn.Open();

                    SQLiteCommand mCmd1 = new SQLiteCommand("UPDATE Item_Table SET [Due Date]='" + Variables.userSelectedDate + "' WHERE Item='" + dataGridView1.SelectedCells[0].Value + "';", mConn);
                    mCmd1.ExecuteNonQuery();

                    MessageBox.Show("You have successfully renewed/extended the loan of " + dataGridView1.SelectedCells[0].Value, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (SQLiteException Ex)
            {
                MessageBox.Show("Exception: " + Ex);
            }

            mConn.Close();
        }
    }
}

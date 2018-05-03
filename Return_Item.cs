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
    public partial class Return_Item : Form
    {
        public Return_Item()
        {
            InitializeComponent();
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Return_Item_Load(object sender, EventArgs e)
        {
            SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

            try
            {
                mConn.Open();

                using (var adapter = new SQLiteDataAdapter("select Item from Item_Table WHERE On_Loan=1 AND [Loaned To]='" + Variables.currentLoggedInUser + "';", mConn))
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
                var confirmResult = MessageBox.Show("Please confirm you would like to return " + dataGridView1.SelectedCells[0].Value, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    mConn.Open();

                    SQLiteCommand mCmd1 = new SQLiteCommand("UPDATE Item_Table SET On_Loan=0, [Loan Date]=NULL, [Loaned To]=NULL, [Due Date]=NULL WHERE Item='" + dataGridView1.SelectedCells[0].Value + "';", mConn);
                    mCmd1.ExecuteNonQuery();

                    MessageBox.Show("You have successfully returned " + dataGridView1.SelectedCells[0].Value, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

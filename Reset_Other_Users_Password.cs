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
    public partial class Reset_Other_Users_Password : Form
    {
        public Reset_Other_Users_Password()
        {
            InitializeComponent();
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset_Other_Users_Password_Load(object sender, EventArgs e)
        {
            SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

            try
            {
                mConn.Open();

                using (var adapter = new SQLiteDataAdapter("select Username from User_Table WHERE Username!='" + Variables.currentLoggedInUser + "';", mConn))
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
                var confirmResult = MessageBox.Show("Please confirm you would like to reset the password of user " + dataGridView1.SelectedCells[0].Value, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    mConn.Open();

                    SQLiteCommand mCmd = new SQLiteCommand("Update User_Table set Password='P@ssw0rd1' WHERE Username='" + dataGridView1.SelectedCells[0].Value + "';", mConn);
                    mCmd.ExecuteNonQuery();

                    MessageBox.Show("The password for user " + dataGridView1.SelectedCells[0].Value + " has been reset to P@ssw0rd1", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

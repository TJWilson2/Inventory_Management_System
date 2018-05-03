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
    public partial class View_Loaned_Items : Form
    {
        public View_Loaned_Items()
        {
            InitializeComponent();
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void View_Loaned_Items_Load(object sender, EventArgs e)
        {
            SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");
            
            try
            {
                mConn.Open();

                using (var adapter = new SQLiteDataAdapter("select Item, [Loaned To], [Loan Date], [Due Date] from Item_Table WHERE On_Loan=1 ORDER BY [Due Date] asc;", mConn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    this.dataGridView1.DataSource = table;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string todaysDate = DateTime.Now.ToString("dd/MM/yyyy");
                    string itemDueDate = (row.Cells["Due Date"].Value.ToString());

                    if (DateTime.Parse(itemDueDate) < DateTime.Parse(todaysDate))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
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
    }
}

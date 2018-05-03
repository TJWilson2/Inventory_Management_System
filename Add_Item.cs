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
    public partial class Add_Item : Form
    {
        public Add_Item()
        {
            InitializeComponent();
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Item_Button_Click(object sender, EventArgs e)
        {
            if (Item.Text == null || string.IsNullOrEmpty(Item.Text) || string.IsNullOrWhiteSpace(Item.Text))
            {
                MessageBox.Show("Please enter an Item name", "Invalid Item name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Item.Text.Length < 2)
            {
                MessageBox.Show("Item name must contain atleast two characters in length", "Invalid Item name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

                try
                {
                    mConn.Open();
                    SQLiteCommand mCmd2 = new SQLiteCommand("select * from Item_Table WHERE Item='" + Item.Text + "';", mConn);
                    SQLiteDataReader reader = mCmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Item " + Item.Text + " already exists within the database. Please enter a unique item name", "Invalid Item name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var confirmResult = MessageBox.Show("Are you sure you want to add the item " + Item.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult == DialogResult.Yes)
                        {
                            SQLiteCommand mCmd1 = new SQLiteCommand("insert into Item_Table (Item, On_Loan) values ('" + Item.Text + "',0);", mConn);
                            mCmd1.ExecuteNonQuery();
                            MessageBox.Show("Item Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
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
}

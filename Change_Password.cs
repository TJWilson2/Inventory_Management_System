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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            if (Password.Text == null || string.IsNullOrEmpty(Password.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Please enter current Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password.Text == New_Password.Text)
            {
                MessageBox.Show("Current and New Passwords are identical", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (New_Password.Text != New_Password_2.Text)
            {
                MessageBox.Show("New Passwords do not match", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

                try
                {
                    mConn.Open();

                    SQLiteCommand mCmd1 = new SQLiteCommand("select * from User_Table WHERE Username='" + Variables.currentLoggedInUser + "';", mConn);
                    SQLiteDataReader reader = mCmd1.ExecuteReader();

                    if (Password.Text == reader["Password"].ToString())
                    {
                        SQLiteCommand mCmd = new SQLiteCommand("Update User_Table set Password='" + New_Password.Text + "' WHERE Username='" + Variables.currentLoggedInUser + "';", mConn);
                        mCmd.ExecuteNonQuery();
                        MessageBox.Show("Password successfully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Current Password Incorrect", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SQLiteException Ex)
                {
                    MessageBox.Show("Exception: " + Ex);
                }

                mConn.Close();
            }
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (Username.Text == null || string.IsNullOrEmpty(Username.Text) || string.IsNullOrWhiteSpace(Username.Text))
            {
                MessageBox.Show("Please enter a username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Username.Text.Contains("."))
            {
                MessageBox.Show("Username must contain a . character seperating first and last name", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Username.Text.Length < 3)
            {
                MessageBox.Show("Username must contain atleast three characters in length", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

                try
                {
                    mConn.Open();
                    SQLiteCommand mCmd2 = new SQLiteCommand("select * from User_Table WHERE Username='" + Username.Text + "';", mConn);
                    SQLiteDataReader reader = mCmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Username " + Username.Text + " already exists within the database. Please enter a unique username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Password.Text == null || string.IsNullOrEmpty(Password.Text) || string.IsNullOrWhiteSpace(Password.Text))
                    {
                        MessageBox.Show("Please enter a password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Password.Text != ConfirmationPassword.Text)
                    {
                        MessageBox.Show("Passwords do not match", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (AuthenticationKey.Text == null || string.IsNullOrEmpty(AuthenticationKey.Text) || string.IsNullOrWhiteSpace(AuthenticationKey.Text))
                    {
                        MessageBox.Show("Please enter an authentication key", "Invalid Authentication Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (AuthenticationKey.Text != "0" && AuthenticationKey.Text != "1")
                    {
                        MessageBox.Show("Invalid authentication key entered", "Invalid Authentication Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var confirmResult = MessageBox.Show("Are you sure you want to register the user " + Username.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult == DialogResult.Yes)
                        {
                            SQLiteCommand mCmd1 = new SQLiteCommand("insert into User_Table (Username, Password, Admin) values ('" + Username.Text + "', '" + Password.Text + "',  '" + AuthenticationKey.Text + "');", mConn);
                            mCmd1.ExecuteNonQuery();
                            MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Variables.loginSuccess = false;
            Variables.adminLoggedIn = false;
            Variables.currentLoggedInUser = "";
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Variables.loginSuccess = false;
            Variables.adminLoggedIn = false;
            Variables.currentLoggedInUser = "";

            if (Username.Text == null || string.IsNullOrEmpty(Username.Text) || string.IsNullOrWhiteSpace(Username.Text))
            {
                MessageBox.Show("Please enter a username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (Password.Text == null || string.IsNullOrEmpty(Password.Text) || string.IsNullOrWhiteSpace(Password.Text))
                        {
                            MessageBox.Show("Please enter a password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (Password.Text == reader["Password"].ToString())
                            {
                                MessageBox.Show("Successfully logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Variables.loginSuccess = true;
                                Variables.currentLoggedInUser = Username.Text;
                                if (reader["Admin"].ToString() == "True")
                                {
                                    Variables.adminLoggedIn = true;
                                }
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Password Incorrect", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username entered does not exist within the database", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SQLiteException Ex)
                {
                    MessageBox.Show("Exception: " + Ex);
                }

                mConn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Variables.loginSuccess = false;
            Variables.adminLoggedIn = false;
            Variables.currentLoggedInUser = "";
        }
    }
}

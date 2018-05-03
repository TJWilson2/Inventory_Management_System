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
    public partial class User_Page : Form
    {
        public User_Page()
        {
            InitializeComponent();
            if (Variables.adminLoggedIn)
            {
                Add_Items_Button.Visible = true;
                Remove_Items_Button.Visible = true;
                Remove_User_Button.Visible = true;
                Reset_Password_Button.Visible = true;
            }
            else
            {
                Add_Items_Button.Visible = false;
                Remove_Items_Button.Visible = false;
                Remove_User_Button.Visible = false;
                Reset_Password_Button.Visible = false;
            }
        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Change_Password frm = new Change_Password();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void Add_Items_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Add_Item frm = new Add_Item();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void Remove_Items_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Remove_Item frm = new Remove_Item();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void Remove_User_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Remove_User frm = new Remove_User();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void Reset_Password_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Reset_Other_Users_Password frm = new Reset_Other_Users_Password();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void Delete_Account_Button_Click(object sender, EventArgs e)
        {
            SQLiteConnection mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "/database.db");

            try
            {
                var confirmResult = MessageBox.Show("Please confirm you would like to delete your account " + Variables.currentLoggedInUser, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    mConn.Open();

                    SQLiteCommand mCmd = new SQLiteCommand("DELETE from User_Table WHERE Username='" + Variables.currentLoggedInUser + "';", mConn);
                    mCmd.ExecuteNonQuery();

                    MessageBox.Show("You have successfully removed your user account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (SQLiteException Ex)
            {
                MessageBox.Show("Exception: " + Ex);
            }

            mConn.Close();
        }

        private void Homepage_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

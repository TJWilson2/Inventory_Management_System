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
    public partial class Main : Form
    {
        SQLiteConnection mConn;

        public Main()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Variables.loginSuccess = false;
            Variables.adminLoggedIn = false;

            Hide();
            Login frm = new Login();
            frm.ShowDialog();
            frm = null;
            Show();

            if (Variables.loginSuccess)
            {
                Hide();
                User_Page frm1 = new User_Page();
                frm1.ShowDialog();
                frm1 = null;
                Show();
            }
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Register frm = new Register();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void Loan_Item_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Loan_Item frm = new Loan_Item();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void View_Loaned_Items_Button_Click(object sender, EventArgs e)
        {
            Hide();
            View_Loaned_Items frm = new View_Loaned_Items();
            frm.ShowDialog();
            frm = null;
            Show();
        }

        private void Return_Item_Button_Click(object sender, EventArgs e)
        {
            Hide();

            if (Variables.loginSuccess)
            {
                Return_Item frm1 = new Return_Item();
                frm1.ShowDialog();
                frm1 = null;
            }
            else
            {
                Login frm = new Login();
                frm.ShowDialog();
                frm = null;
                if (Variables.loginSuccess)
                {
                    Return_Item frm1 = new Return_Item();
                    frm1.ShowDialog();
                    frm1 = null;
                }
            }

            Show();
        }

        private void Renew_Extend_Loan_Button_Click(object sender, EventArgs e)
        {
            Hide();

            if (Variables.loginSuccess)
            {
                Renew_Extend_Loan frm1 = new Renew_Extend_Loan();
                frm1.ShowDialog();
                frm1 = null;
            }
            else
            {
                Login frm = new Login();
                frm.ShowDialog();
                frm = null;
                if (Variables.loginSuccess)
                {
                    Renew_Extend_Loan frm1 = new Renew_Extend_Loan();
                    frm1.ShowDialog();
                    frm1 = null;
                }
            }

            Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mConn = new SQLiteConnection("Data Source=" + Application.StartupPath + "database.db");

            try
            {
                mConn.Open();
                mConn.Close();
            }
            catch (SQLiteException Ex)
            {
                MessageBox.Show("Exception: " + Ex);
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (Variables.loginSuccess)
            {
                Login_Button.Visible = false;
                Register_Button.Visible = false;
                Logout_Button.Visible = true;
                Settings_Button.Visible = true;
                Logged_In_User_Label.Visible = true;
                Logged_In_User_Label.Text = "Current logged in user is: " + Variables.currentLoggedInUser;
            }
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Variables.loginSuccess = false;
            Login_Button.Visible = true;
            Register_Button.Visible = true;
            Logout_Button.Visible = false;
            Settings_Button.Visible = false;
            Logged_In_User_Label.Visible = false;
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Hide();
            User_Page frm1 = new User_Page();
            frm1.ShowDialog();
            frm1 = null;
            Show();
        }
    }
}

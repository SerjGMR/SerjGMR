using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLoginWarmup
{
    public partial class signupLabel : Form
    {
        public signupLabel()
        {
            InitializeComponent();
        }
        List<Account> accounts = new List<Account>();
        private void Form1_Load(object sender, EventArgs e)
        {

            accounts.Add(new Account("User1", "pAsSwOrD"));
            login.BringToFront();
            signup.Visible = false;

            signup.Location = login.Location;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < accounts.Count; x++)
            {
                if (passBox.Text == accounts[x].getPassword() && userBox.Text == accounts[x].getUsername())
                {
                    login.Visible = false;
                    accessLabel.Visible = true;
                    accessLabel.Text = $"Access Granted for account {userBox.Text}";
                    label6.Visible = false;
                    label2.Visible = false;
                    label1.Visible = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            signup.BringToFront();
            signup.Visible = true;
            login.Visible = false;
            corner1.Visible = false;
            label7.Visible = true;
            label6.Visible = true;
            userBoxSignup.Text = "";
            passBoxSignup.Text = "";
            userBox.Text = "";
            passBox.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            login.BringToFront();
            login.Visible = true;
            signup.Visible = false;
            label7.Visible = false;
            corner1.Visible = true;
            label6.Visible = false;
            userBoxSignup.Text = "";
            passBoxSignup.Text = "";
            userBox.Text = "";
            passBox.Text = "";
        }

        private void submitSignup_Click_1(object sender, EventArgs e)
        {
            bool unique = true;
            for (int x = 0; x < accounts.Count; x++)
            {
                if (userBoxSignup.Text == accounts[x].getUsername() || userBoxSignup.Text == "" || passBoxSignup.Text == "")
                {
                    unique = false;
                }
            }
            if (unique == true)
            {
                Account account = new Account(userBoxSignup.Text, passBoxSignup.Text);
                accounts.Add(account);
                login.BringToFront();
                login.Visible = true;
                signup.Visible = false;
                label7.Visible = false;
                corner1.Visible = true;
                label6.Visible = false;
                userBoxSignup.Text = "";
                passBoxSignup.Text = "";
                userBox.Text = "";
                passBox.Text = "";
                
            }
        }
    }
}

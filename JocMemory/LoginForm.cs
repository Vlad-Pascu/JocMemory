using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JocMemory
{
    public partial class fLogin : Form
    {
        public static fMenu fMenu= null;
        public static SQLUtility sqlUtility= new SQLUtility();
        public fLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            sqlUtility.Connect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lUserError.Visible = false;
            lPasswordError.Visible = false;
            if (NoErrorOnLogin(tbUserName.Text, tbPassword.Text) == true)
            {
                fMenu = new fMenu(tbUserName.Text);
                fMenu.Show();
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lUserError.Visible = false;
            lPasswordError.Visible = false;
            if (NoErrorsOnRegister(tbUserName.Text, tbPassword.Text) == true)
            {
                string password = ComputeSHA256(tbPassword.Text);
                sqlUtility.AddPlayer(tbUserName.Text, password);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            fMenu = new fMenu("Guest");
            fMenu.Show();
            this.Hide();
        }

        private bool NoErrorOnLogin(string username, string password)
        { 
            Player player = sqlUtility.GetPlayerByUsername(tbUserName.Text);
            if(player==null)
            {
                lUserError.Text = "Wrong username";
                lUserError.Visible = true;
                return false;
            }
            password = ComputeSHA256(password);
            if (password != player.Password)
            {
                lPasswordError.Text = "Wrong password";
                lPasswordError.Visible = true;
                return false;
            }
            return true;
        }

       

        private bool NoErrorsOnRegister(string username, string password)
        {
            if (ValidUsername(username) == false)
                return false;
            if (ValidPassword(password)==false)
                return false;
            return true;
        }

        private bool ValidPassword(string password)
        {
            if (String.IsNullOrEmpty(password) == true)
            {
                lPasswordError.Text = "Insert password";
                lPasswordError.Visible = true;
                return false;
            }
            return true;
        }

        private bool ValidUsername(string username)
        {
            if (String.IsNullOrEmpty(username) == true)
            {
                lUserError.Text = "Insert username";
                lUserError.Visible = true;
                return false;
            }
            else
            {
                List<string> players = sqlUtility.GetAllPlayers();
                foreach (string name in players)
                {
                    if (name == tbUserName.Text)
                    {
                        lUserError.Text = " Username taken";
                        lUserError.Visible = true;
                        return false;
                    }
                }
            }
            return true;
        }

        private static string ComputeSHA256(string s)
        {
            string hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

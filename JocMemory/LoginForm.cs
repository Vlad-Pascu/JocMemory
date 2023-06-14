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
        static SQLUtility sqlUtility= new SQLUtility();
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

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (NoErrors(tbUserName.Text, tbPassword.Text) == true)
            {
                sqlUtility.AddPlayer(tbUserName.Text, tbPassword.Text);
            }
        }

        private bool NoErrors(string username, string password)
        {
            if(String.IsNullOrEmpty(username)==true)
            {
                lbUserError.Text = "Insert username";
                lbUserError.Visible = true;
                return false;
            }
            else // trebuie modificata si prentru login + parola
            {
                List<string> players = sqlUtility.GetAllPlayers();
                foreach(string name in players)
                {
                    if(name == tbUserName.Text) 
                    {
                        lbUserError.Text = " Username taken";
                        lbUserError.Visible = true;
                        return false;
                    }
                }
            }
            if(String.IsNullOrEmpty(password) == true)
            {
                lPasswordError.Text= "Insert password";
                lPasswordError.Visible = true;
                return false;
            }
            else
            {
                //check for password
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
    }
}

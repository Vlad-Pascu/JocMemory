using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocMemory
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        public fMenu(string username)
        {
            InitializeComponent();
            this.lPlayerName.Text = username;
            //this.lCoins.Text=coins;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

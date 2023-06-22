using SimpleTCP;
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
    public partial class fConnection : Form
    {
        Player player;
        public fConnection()
        {
            InitializeComponent();
        }

        public fConnection(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            fMultiGame fMulti = new fMultiGame(player, true);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            fMultiGame fMulti = new fMultiGame(player, false);
        }

    }
}

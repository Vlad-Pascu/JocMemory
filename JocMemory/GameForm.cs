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
    public partial class fGame : Form
    {
        Game game;
        public fGame()
        {
            InitializeComponent();
        }

        public fGame(Game game)
        {
            InitializeComponent();
            this.game = game;
            game.Run();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}

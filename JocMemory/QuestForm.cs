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
    public partial class fQuests : Form
    {
        public fQuests()
        {
            InitializeComponent();
        }

        public fQuests(List<Quest> quests)
        {
            InitializeComponent();
            foreach(Quest quest in quests)
            {
                listQuests.Items.Add(quest.Name+ "  R: "+quest.Reward);
            }
        }

        private void fQuests_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fLogin.fMenu.Show();
            this.Close();
        }
    }
}

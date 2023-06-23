using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocMemory
{
    public partial class fHelpResult : Form
    {
        const string HELP = "Jocul este simplu. Tot ce ai de facut este sa apesi pe cate 2 carti " +
                            "pana sunt gasesti toate perechile. Pentru jocul multiplayer, trebuie sa apesi pe butonul server" +
                            "iar celalalt jucator trebuie sa introduca ip-ul tau si portul pe care este host-at jocul.";
        Player player;
        public fHelpResult()
        {
            InitializeComponent();
        }

        public fHelpResult(Player player)
        {
            InitializeComponent();
            lHelp.Text = HELP;
            this.player = player;
            List<SingleResults> results= fLogin.sqlUtility.GetSingleResults(player);
            Debug.WriteLine(results.Count);
            foreach(SingleResults result in results) 
            { 
                listSingleResults.Items.Add("Match "+ result.ResultId+ " : "+ player.Username + 
                                            " score : "+ result.Score+ " time : "+ result.Time);
            }
            List<MultiResults> multiResults = fLogin.sqlUtility.GetMultiResults(player);

            foreach(MultiResults multi in multiResults)
            {
                string player1Name = fLogin.sqlUtility.GetNameById(multi.Player1Id);
                string player2Name=fLogin.sqlUtility.GetNameById(multi.Player2Id);
                listMultiResults.Items.Add("Match " + multi.ResultId + " : " + player1Name +
                                           " : " + multi.Score1 + " " + player2Name + " : " + multi.Score2);
            }

        }

        private void fHelpResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            fMenu fMenu= new fMenu(player.Username);
            fMenu.Show();
            this.Hide();
        }
    }
}

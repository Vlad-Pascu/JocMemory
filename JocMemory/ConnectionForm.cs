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
        public static SimpleTcpClient client;
        public static SimpleTcpServer server;
        public static string messageSend;
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
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder= Encoding.UTF8;
            System.Net.IPAddress address=System.Net.IPAddress.Parse(tbIP.Text);
            server.Start(address, Convert.ToInt32(tbPort.Text));
            //messageSend += "Hello " + player.PlayerId.ToString();
            //server.BroadcastLine(messageSend);
            server.DataReceived += Server_DataReceived;
            fMultiGame.isServer = true;
            fMultiGame fMulti = new fMultiGame(player, -1);
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            string messageReceived = e.MessageString;
            if (messageReceived.StartsWith("Hello "))
            {
                string[] data= messageReceived.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                int player2Id = Convert.ToInt32(data[1]);
            }
            if (messageReceived.StartsWith("Gata "))
                fMultiGame.ready = true;
            messageSend = "";
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            client=new SimpleTcpClient();
            client.Delimiter = 0x13;
            client.StringEncoder= Encoding.UTF8;
            client.Connect(tbIP.Text, Convert.ToInt32(tbPort.Text));
            //messageSend = "Hello " + player.PlayerId.ToString()+" ";
            //client.WriteLine(messageSend);
            client.DataReceived += Client_DataReceived;
            fMultiGame.isClient = true;
            fMultiGame fMulti = new fMultiGame(player, -1);
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            string messageReceived = e.MessageString;
            if (messageReceived.StartsWith("Hello "))
            {
                string[] data = messageReceived.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int player2Id = Convert.ToInt32(data[1]);
            }
            if (messageReceived.StartsWith("Tabla "))
            {
                string[] data = messageReceived.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                for(int i=1;i<data.Length;i++)
                {
                    fMultiGame.cardsOrder += data[i] + " ";
                }
                fMultiGame.orderDone = true;
            }
            messageSend = "";
        }
    }
}

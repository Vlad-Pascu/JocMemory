using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JocMemory
{
    internal class Server
    {
        public Server()
        {
            Task t = Task.Factory.StartNew(() =>
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 8080;

                TcpListener listener = new TcpListener(ipAddress, port);

                listener.Start();
                Console.WriteLine("Server started. Waiting for clients...");

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Client connected.");

                    NetworkStream stream = client.GetStream();

                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("Data received from client: " + dataReceived);

                    // Process the data (you can implement your logic here)

                    string responseData = "Server response: Data received successfully.";
                    byte[] responseBytes = Encoding.ASCII.GetBytes(responseData);
                    stream.Write(responseBytes, 0, responseBytes.Length);
                    Console.WriteLine("Response sent to client.");

                    client.Close();
                    Console.WriteLine("Client disconnected.");
                }
            });
            
        }
    }
}

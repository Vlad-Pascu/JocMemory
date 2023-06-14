using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;

namespace JocMemory
{
    internal class SQLUtility
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        public void Connect()
        {
            string connString = "server=localhost;uid=root;pwd=GeNesisHalo21;database=joc_memory";
            con = new MySqlConnection();
            con.ConnectionString = connString;
            con.Open();
        }

        const int NO_COINS = 0;

        public void AddPlayer(string username, string password)
        {
            adapter = new MySqlDataAdapter();
            string stringSql = " INSERT INTO player (userName,password,coins) VALUES ('" + username + "','" + password + "'," + NO_COINS + ")";
            cmd = new MySqlCommand(stringSql, con);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
        }

        public List<string> GetAllPlayers()
        {
            List<string> list = new List<string>();
            string stringSql = "SELECT userName FROM player";
            cmd = new MySqlCommand(stringSql, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            reader.Close();
            cmd.Dispose();
            return list;
        }
    }
}
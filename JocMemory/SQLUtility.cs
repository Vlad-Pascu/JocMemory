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
    public class SQLUtility
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        const int START_COINS = 500;
        public void Connect()
        {
            string connString = "server=localhost;uid=root;pwd=GeNesisHalo21;database=joc_memory";
            con = new MySqlConnection();
            con.ConnectionString = connString;
            con.Open();
        }



        public void AddPlayer(string username, string password)
        {
            adapter = new MySqlDataAdapter();
            string stringSql = " INSERT INTO player (username,password,coins) " +
                                "VALUES ('" + username + "','" + password + "'," + START_COINS + ")";
            cmd = new MySqlCommand(stringSql, con);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
        }

        public List<string> GetAllPlayers()
        {
            List<string> list = new List<string>();
            string stringSql = "SELECT username FROM player";
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

        public Player GetPlayerByUsername(string name)
        {
            Player player = null;
            string stringSql = "SELECT * FROM player WHERE username = '" + name+ "'";
            cmd = new MySqlCommand(stringSql, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    player = new Player();
                    player.PlayerId = reader.GetInt32(0);
                    player.Username= reader.GetString(1);
                    player.Password= reader.GetString(2);
                    player.Money= reader.GetInt32(3);
                    player.Quests = null;
                }
            }
            reader.Close();
            cmd.Dispose();
            return player;
        }

        public List<Quest> GetQuestForPlayer(int playerId)
        {
            List<Quest> quests =new List<Quest>();
            string stringSql = "SELECT q.questId,name, reward FROM joc_memory.player_has_quest pq " +
                                "JOIN quest q ON pq.questId " +
                                "WHERE pq.questId=q.questId AND playerId=" + playerId;
            cmd= new MySqlCommand(stringSql, con);
            reader=cmd.ExecuteReader();
            if(reader.HasRows) 
            {
                while (reader.Read())
                {
                    Quest quest= new Quest();
                    quest.QuestId = reader.GetInt32(0);
                    quest.Name= reader.GetString(1);
                    quest.Requirements = null;
                    quest.Reward = reader.GetInt32(2);
                    quests.Add(quest);
                }
            }
            reader.Close();
            cmd.Dispose();
            foreach(Quest quest in quests)
                quest.Requirements = this.GetRequirementForQuest(quest.QuestId);
            return quests;
        }

        public List<Requirement> GetRequirementForQuest(int questId)
        {
            List<Requirement> requirements = new List<Requirement>();
            string stringSql = "SELECT r.requirementId, name,amount FROM joc_memory.quest_has_requirement j " +
                                "JOIN requirement r ON j.requirementId " +
                                "WHERE j.requirementId=r.requirementId AND questId=" + questId;
            cmd=new MySqlCommand(stringSql, con);
            reader=cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    Requirement requirement= new Requirement();
                    requirement.RequirementId = reader.GetInt32(0);
                    requirement.ObjectiveName = reader.GetString(1);
                    requirement.ObjectiveAmount = reader.GetInt32(2);
                    requirements.Add(requirement);
                }
            }
            reader.Close();
            cmd.Dispose();
            return requirements;
        }

        public void UpdatePlayerCoins(Player player)
        {
            adapter = new MySqlDataAdapter();
            string stringSql = "UPDATE player " +
                               "SET player.coins=" + player.Money +
                               " WHERE player.playerId=" + player.PlayerId;
            cmd=new MySqlCommand(stringSql, con);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void AddSinglePlayerResult(int playerId, int score, int time)
        {
            adapter=new MySqlDataAdapter();
            string stringSql= " INSERT INTO singleplayer_result (playerId,score,time) " +
                                "VALUES (" + playerId + "," + score + "," + time + ")";
            cmd=new MySqlCommand(stringSql, con);
            adapter.InsertCommand= cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
        }

        internal void AddMultiPlayerResult(int player1Id, int player2Id, int score)
        {
            adapter = new MySqlDataAdapter();
            string stringSql = " INSERT INTO multiplayer_result (player1Id,player2Id,score_player1,score_player2) " +
                                "VALUES (" + player1Id + "," + player2Id + "," + score + ","+ (14-score)+")";
            cmd = new MySqlCommand(stringSql, con);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
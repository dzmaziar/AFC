using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class SwitchGuns
    {
        public static string[] Classified(string collection)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Convert'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> ans = new List<string>();
            while (reader.Read())
            {
                ans.Add(reader[0].ToString());
            }
            string[] answer = ans.ToArray();
            reader.Close();
            db.CloseConnection();
            return answer;

        }
        public static string[] Restricted(string collection)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
           
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Classified'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> ans = new List<string>();
            while (reader.Read())
            {
                ans.Add(reader[0].ToString());

            }
            string[] answer = ans.ToArray();
            reader.Close();
            db.CloseConnection();
            return answer;
        }
        public static string[] Mil_Spec(string collection)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            List<string> list = new List<string>();
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Restricted'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
           
            List<string> ans = new List<string>();
            while (reader.Read())
            {
                ans.Add(reader[0].ToString());
              
            }
            string[] answer = ans.ToArray() ;
            reader.Close();
            db.CloseConnection();
            return answer;
        }

        public static string[] Industrial(string collection)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
         
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Mil-Spec'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> ans = new List<string>();
            while (reader.Read())
            {
                ans.Add(reader[0].ToString());

            }
            string[] answer = ans.ToArray();
            reader.Close();
            db.CloseConnection();
            return answer;
        }
        public static string[] Consumer(string collection)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Industrial Grade'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> ans = new List<string>();
            while (reader.Read())
            {
                ans.Add(reader[0].ToString());

            }
            string[] answer = ans.ToArray();
            reader.Close();
            db.CloseConnection();
            return answer;
        }
    }
}

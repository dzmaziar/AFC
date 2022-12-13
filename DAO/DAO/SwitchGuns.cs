using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class SwitchGuns
    {
        public static string[] Classified(string collection)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string[] answer = null; 
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Convert'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                answer[i] = reader[0].ToString();
                i++;
            }
            reader.Close();
            db.CloseConnection();
            return answer;

        }
        public static string[] Restricted(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string[] answer = null;
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Classified'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                answer[i] = reader[0].ToString();
                i++;
            }

            reader.Close();
            db.CloseConnection();
            return answer;
        }
        public static string[] Mil_Spec(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string[] answer = null;
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Restricted'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                answer[i] = reader[0].ToString();
                i++;
            }

            reader.Close();
            db.CloseConnection();
            return answer;
        }

        public static string[] Industrial(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string[] answer = null;
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Mil-Spec'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                answer[i] = reader[0].ToString();
                i++;
            }

            reader.Close();
            db.CloseConnection();
            return answer;
        }
        public static string[] Consumer(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string[] answer = null;
            string quary = "SELECT name FROM afc WHERE collection = @collection AND quality = 'Industrial Grade'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@collection", collection);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                answer[i] = reader[0].ToString();
                i++;
            }

            reader.Close();
            db.CloseConnection();
            return answer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AFC.DAO
{
    internal class SwitchGuns
    {
        public static void Classified(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT name FROM afc WHERE collection = '" + collection +
                            "' AND quality = 'Convert'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DatacomboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            db.CloseConnection();
        }
        public static void Restricted(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT name FROM afc WHERE collection = '" + collection +
                            "' AND quality = 'Classified'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DatacomboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            db.CloseConnection();
        }
        public static void Mil_Spec(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT name FROM afc WHERE collection = '" + collection +
                            "' AND quality = 'Restricted'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DatacomboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            db.CloseConnection();
        }

        public static void Industrial(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT name FROM afc WHERE collection = '" + collection +
                            "' AND quality = 'Mil-Spec'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DatacomboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            db.CloseConnection();
        }
        public static void Consumer(string collection, ComboBox DatacomboBox1)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT name FROM afc WHERE collection = '" + collection +
                            "' AND quality = 'Industrial Grade'";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DatacomboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            db.CloseConnection();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class SearchMaxMinFloat
    {
        public static double SearchMinFloat(string selectedItem)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
           var selectGun = DatacomboBox1.SelectedItem.ToString(); ;
           double minFloat = 0;
            string quary = "SELECT minimum FROM afc WHERE name = @selectGun";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@selectGun", selectGun);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                minFloat = double.Parse(reader[0].ToString());
            }
           
            reader.Close();
            db.CloseConnection();
            return minFloat;
        }

        public static double SearchMaxFloat(string selectedItem)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            double maxFloat = 0;
            var selectGun = DatacomboBox1.SelectedItem.ToString(); ;
            double minFloat = 0;
            string quary = "SELECT maximum FROM afc WHERE name = @selectGun";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@selectGun", selectGun);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                maxFloat = double.Parse(reader[0].ToString());
            }

            reader.Close();
            db.CloseConnection();
            return maxFloat;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class SelectGunQuality
    {
        public static string SelectQuality(string nameOfGun)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary = "SELECT quality FROM afc WHERE name = @nameOfGun";
            string quality = null;
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            command.Parameters.AddWithValue("@nameOfGun", nameOfGun);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               quality = reader[0].ToString();

            }
            reader.Close();
            db.CloseConnection();
            return quality;
        }
    }
}

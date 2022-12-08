using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AFC.DAO
{
    internal class SelectGunQuality
    {
        public static string SelectQuality(string nameOfGun)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary2 = "SELECT quality FROM afc WHERE name = '" + nameOfGun + "'";
            string? quality = null;
            MySqlCommand command2 = new MySqlCommand(quary2, db.getConnection());
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
               quality = reader2[0].ToString();

            }
            reader2.Close();
            db.CloseConnection();
            return quality;
        }
    }
}

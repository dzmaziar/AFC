using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AFC.DAO
{
    internal class SelectGunCollection
    {
        private static string? collection;

        public static string SelectCollection(string nameOfGun)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary1 = "SELECT collection FROM afc WHERE name = '" + nameOfGun + "'";
            string quary2 = "SELECT quality FROM afc WHERE name = '" + nameOfGun + "'";
            MySqlCommand command = new MySqlCommand(quary1, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                collection = reader[0].ToString();
            }
            
            reader.Close();
            db.CloseConnection();
            return collection;
        }
    }
}

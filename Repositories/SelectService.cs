using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.IRepository;
using DAO;
using MySql.Data.MySqlClient;

namespace AFC.Repositories
{
    public class SelectService : ISelectService
    {
        public string SelectGunCollection(string nameOfGun)
        {
            string? collection = null;
            DataBase db = new DataBase();
            db.OpenConnection();
            string quary1 = "SELECT collection FROM afc WHERE name = @nameOfGun";
            MySqlCommand command = new MySqlCommand(quary1, db.getConnection());
            command.Parameters.AddWithValue("@nameOfGun", nameOfGun);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                collection = reader[0].ToString();
            }

            reader.Close();
            db.CloseConnection();
            return collection;
        }

        public string SelectGunQuality(string nameOfGun)
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

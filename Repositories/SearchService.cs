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
    public class SearchService : ISearchService
    {
        public double SearchMaxFloat(string selectedItem)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            double maxFloat = 0;
            var selectGun = selectedItem; ;
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

        public double SearchMinFloat(string selectedItem)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            var selectGun = selectedItem; ;
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

        public List<string> SearchPrefixName(string text)
        {
            var db = new DataBase();
            db.OpenConnection();
            var temp = new List<string>();
            string quary = "SELECT * FROM nameofgun";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(reader[0].ToString());

            }
            reader.Close();
            db.CloseConnection();
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class SearchPrefixnameService
    {
        public int SearchPrefixNameOnPage(string Text)
        {
            var db = new DataBase();
            db.OpenConnection();
            var temp = new List<string>();
            string quary = "SELECT * FROM nameofgun";
            MySqlCommand command = new MySqlCommand(quary, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                temp.Add(reader[0].ToString());
                i++;
            }
            int a = 0;
            for (int j = 0;j < temp.Count;j++)
            {
                a = Text.IndexOf(temp[j]);
                if (a != -1 && a != 0)
                {
                    break;
                }
            }
            reader.Close();
            db.CloseConnection();
            return a;

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.DAO
{
    internal class ViewAllItems
    {
        public static void ViewAllItemsInDB(DataGridView dataGridView)
        {
            var db = new DataBase();
            db.OpenConnection();
            var quary = "SELECT name,collection,quality,minimum,maximum,seed FROM afc ORDER BY collection";
            var command = new MySqlCommand(quary, db.getConnection());
            var reader = command.ExecuteReader();
            var data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();


            }
            reader.Close();
            db.CloseConnection();

            foreach (var s in data)
            {
                dataGridView.Rows.Add(s);
            }
        }
    }
}

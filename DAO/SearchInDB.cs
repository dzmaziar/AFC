using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.DAO
{
    internal class SearchInDB
    {
        public static void SearchInDataBase(string text,DataGridView gridData)
        {
            var db = new DataBase();
            db.OpenConnection();
            var adapt = new MySqlDataAdapter("SELECT name,collection,quality,minimum,maximum FROM afc WHERE name LIKE '" + text + "%'", db.getConnection());
            var dt = new DataTable();
           // dt.Locale = new CultureInfo("en-gb");
            adapt.Fill(dt);
            gridData.Columns.Clear();
            gridData.DataSource = dt;
            db.CloseConnection();
           
        }
    }
}

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAO
{
    public class SearchInDB
    {
        public static void SearchInDataBase(string text,DataGridView gridData)
        {
            var db = new DataBase();
            db.OpenConnection();
            var adapt = new MySqlDataAdapter("SELECT name,collection,quality,minimum,maximum FROM afc WHERE name LIKE  '" + text + "%'", db.getConnection());
            var dt = new DataTable();
            adapt.Fill(dt);
            gridData.Columns.Clear();
            gridData.DataSource = dt;
            db.CloseConnection();
           
        }
    }
}

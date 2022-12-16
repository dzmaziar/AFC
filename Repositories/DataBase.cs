using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.IRepository;
namespace DAO
{
    public class DataBase : IDbStandartActions
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=afc");
        IAddInDb _add;
       public  DataBase()
        {
           
        }
       public  DataBase(IAddInDb add)
            {
            _add = add;
            }
        public void OpenConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }

        public List<string[]> GetAllItems()
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
            return data;
        }

        public DataTable SearchInDB(string text)
        {
            var db = new DataBase();
            db.OpenConnection();
            var adapt = new MySqlDataAdapter("SELECT name,collection,quality,minimum,maximum FROM afc WHERE name LIKE  '" + text + "%'", db.getConnection());
            var dt = new DataTable();
            adapt.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        public void AddToDb()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            DataTable table = new DataTable();
            var buff = _add.GetArrayOfParameters();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `afc` (`name`,`collection`,`quality`,`minimum`,`maximum`,`seed`) VALUES (@name,@collection,@quality,@minimum,@maximum,@seed)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = buff[0];
            command.Parameters.Add("@collection", MySqlDbType.VarChar).Value = buff[1];
            command.Parameters.Add("@quality", MySqlDbType.VarChar).Value = buff[2];
            command.Parameters.Add("@minimum", MySqlDbType.Float).Value = buff[3];
            command.Parameters.Add("@maximum", MySqlDbType.Float).Value = buff[4];
            command.Parameters.Add("@seed", MySqlDbType.Float).Value = buff[5];

          
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Создано");
            }
            else
            {
                MessageBox.Show("НЕ Создано");
            }

            db.CloseConnection();
        }
    }
}

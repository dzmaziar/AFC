using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace AFC
{
    public partial class AddToDB : Form
    {
        public AddToDB()
        {
            InitializeComponent();

            this.nameField.Size = new Size(this.nameField.Size.Width, 27);
            this.nameField.AutoSize = false;
            this.collectionField.Size = new Size(this.collectionField.Size.Width, 27);
            this.collectionField.AutoSize = false;
            this.qualityField.Size = new Size(this.qualityField.Size.Width, 27);
            this.qualityField.AutoSize = false;
            this.minField.Size = new Size(this.minField.Size.Width, 27);
            this.minField.AutoSize = false;
            this.maxField.Size = new Size(this.maxField.Size.Width, 27);
            this.maxField.AutoSize = false;
            this.seedField.Size = new Size(this.seedField.Size.Width, 27);
            this.seedField.AutoSize = false;
        }


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ЗАБЛОКИРОВАНО ( НЕ ИСПОЛЬЗУЕТСЯ ПОЛЬЗОВАТЕЛЕМ ВООБЩЕ ) !!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            //String name = nameField.Text;
            //String collection = collectionField.Text;
            //String quality = qualityField.Text;
            //float min = float.Parse(minField.Text);
            //float max = float.Parse(maxField.Text);
            //float seed = float.Parse(seedField.Text);

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `afc` (`name`,`collection`,`quality`,`minimum`,`maximum`,`seed`) VALUES (@name,@collection,@quality,@minimum,@maximum,@seed)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@collection", MySqlDbType.VarChar).Value = collectionField.Text;
            command.Parameters.Add("@quality", MySqlDbType.VarChar).Value = qualityField.Text;
            command.Parameters.Add("@minimum", MySqlDbType.Float).Value = minField.Text;
            command.Parameters.Add("@maximum", MySqlDbType.Float).Value = maxField.Text;
            command.Parameters.Add("@seed", MySqlDbType.Float).Value = seedField.Text;

            db.OpenConnection();
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

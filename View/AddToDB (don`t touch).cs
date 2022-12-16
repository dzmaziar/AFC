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
using AFC.IRepository;

namespace AFC
{
    public partial class AddToDB : Form, IAddInDb
    {
        DataBase _db;
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
            _db = new DataBase(this);
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

           
        }
        public List<string> GetArrayOfParameters()
        {
            List<string> array = new List<string>();
            array.Add(nameField.Text);
            array.Add(collectionField.Text);
            array.Add(qualityField.Text);
            array.Add(minField.Text);
            array.Add(maxField.Text);
            array.Add(seedField.Text);
            return array;
        }

       
    }
}

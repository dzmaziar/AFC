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
using Presenterr;
using AFC.IRepository;
namespace AFC
{
    public partial class ViewDataBase : Form
    {
        
        public ViewDataBase()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartPage add = new StartPage();
            add.Show();
            this.Hide();
        }
        private void searchInDBTextBox_TextChanged(object sender, EventArgs e)
        {
            var a = new DataBase();

         var r = a.SearchInDB(searchInDBTextBox.Text);
            dataGridView.Columns.Clear();
            dataGridView.DataSource = r;

        }

        private void ViewDataBase_Load(object sender, EventArgs e)
        {
            var a = new DataBase();
            var r =a.GetAllItems();
            foreach(var item in r)
            {
                dataGridView.Rows.Add(item);
            }
        }

    }
}

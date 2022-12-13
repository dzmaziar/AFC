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
using Presenter;
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
          SearchInDB.SearchInDataBase(searchInDBTextBox.Text,dataGridView);
        }

        private void ViewDataBase_Load(object sender, EventArgs e)
        {
            ViewAllItems.ViewAllItemsInDB(dataGridView);
        }

    }
}

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
using AFC.Presenter;
using AFClibrary;

namespace AFC
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
          
              InitializeComponent();
            
        }
        private void ViewProcessDataButton_Click(object sender, EventArgs e)
        {
            ViewProcces add = new ViewProcces();
            add.Text = dataTextBox1.Text;
            add.Show();
            
        }
        private void backMainFramepictureBox1_Click(object sender, EventArgs e)
        {
            StartPage add = new StartPage();
            add.Show();
            this.Hide();

        }
        private void dataTextBox1_TextChanged(object sender, EventArgs e)
        {

            MainFramePresenter.SelectGun(dataTextBox1.Text,DatacomboBox1);
        }
        private void doCalculationButton_Click(object sender, EventArgs e)
        {
            MainFramePresenter.Counting(DatacomboBox1,floatTextBox,dataTextBox1);
        }
        private void DatacomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (floatTextBox.Text != "")
            {
                doCalculationButton.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataTextBox1.Text = "0";
            DatacomboBox1.Items.Clear();
            DatacomboBox1.Text = "";
            doCalculationButton.Enabled = false;
            floatTextBox.Clear();
        }
    }
}

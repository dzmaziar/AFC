using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AFC
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToDB add = new AddToDB();
            add.Show();
            this.Hide();
        }

        private void buttonDataBase_Click(object sender, EventArgs e)
        {
            ViewDataBase add = new ViewDataBase();
            add.Show();
            this.Hide();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            Calulator add = new Calulator();
            add.Show();
            this.Hide();
        }

        private void backGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMainFrame_Click(object sender, EventArgs e)
        {
            MainFrame add = new MainFrame();
            add.Show();
            this.Hide();
        }
    }
}

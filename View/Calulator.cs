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
    public partial class Calulator : Form
    {
        public Calulator()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartPage add = new StartPage();
            add.Show();
            this.Hide();
            
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var calculator = new CalulatorPresenter();
            calculator.Calulator();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IEEEtextBox1.Text = "0";
            IEEEtextBox2.Text = "0";
            IEEEtextBox3.Text = "0";
            IEEEtextBox4.Text = "0";
            IEEEtextBox5.Text = "0";
            IEEEtextBox6.Text = "0";
            IEEEtextBox7.Text = "0";
            IEEEtextBox8.Text = "0";
            IEEEtextBox9.Text = "0";
            IEEEtextBox10.Text = "0";
            minFloatIEEEtextBox.Text = "0";
            maxFloatIEEEtextBox.Text = "0";
            RequiredAverageFloatIEEEtextBox.Text = "0";
        }

      
    }
}

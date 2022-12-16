using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenterr;
using Presenterr.View;

namespace AFC
{
    public partial class Calulator : Form, ICalulatorView
    {
        private CalulatorPresenter _presenter;
        public Calulator()
        {
            InitializeComponent();
            _presenter = new CalulatorPresenter(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartPage add = new StartPage();
            add.Show();
            this.Hide();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            _presenter.Calulator();
        }
        public List<double> GetListOfCalculatorBox()
        {
            List<double> list = new List<double>();
            list.Add(double.Parse(IEEEtextBox1.Text));
            list.Add(double.Parse(IEEEtextBox2.Text));
            list.Add(double.Parse(IEEEtextBox3.Text));
            list.Add(double.Parse(IEEEtextBox4.Text));
            list.Add(double.Parse(IEEEtextBox5.Text));
            list.Add(double.Parse(IEEEtextBox6.Text));
            list.Add(double.Parse(IEEEtextBox7.Text));
            list.Add(double.Parse(IEEEtextBox8.Text));
            list.Add(double.Parse(IEEEtextBox9.Text));
            list.Add(double.Parse(IEEEtextBox10.Text));
            return list;
        }
        public List<string>GetListOfFloats()
        {
            List<string> list = new List<string>();
          
            list.Add(RequiredFloatIEEEtextBox.Text);
            list.Add(minFloatIEEEtextBox.Text);
            list.Add(maxFloatIEEEtextBox.Text);
            return list;
        }

        public void SetListOnTextBox(string currentAverage, string req, string averageOfSkins, System.Drawing.Color color)
        {

            CurrentFloatIEEEtextBox.Text = currentAverage;
            RequiredAverageFloatIEEEtextBox.Text = req;
            CurrentFloat10SkinsIEEEtextBox.Text = averageOfSkins;
            CurrentFloatIEEEtextBox.BackColor = color;
            
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

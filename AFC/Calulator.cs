using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            List<double> skinsArr = new List<double>();
            skinsArr.Add(double.Parse(IEEEtextBox1.Text));
            skinsArr.Add(double.Parse(IEEEtextBox2.Text));
            skinsArr.Add(double.Parse(IEEEtextBox3.Text));
            skinsArr.Add(double.Parse(IEEEtextBox4.Text));
            skinsArr.Add(double.Parse(IEEEtextBox5.Text));
            skinsArr.Add(double.Parse(IEEEtextBox6.Text));
            skinsArr.Add(double.Parse(IEEEtextBox7.Text));
            skinsArr.Add(double.Parse(IEEEtextBox8.Text));
            skinsArr.Add(double.Parse(IEEEtextBox9.Text));
            skinsArr.Add(double.Parse(IEEEtextBox10.Text));
            IEEE754Calculator calculator = new IEEE754Calculator(skinsArr,Convert.ToDouble(RequiredFloatIEEEtextBox.Text), Convert.ToDouble(minFloatIEEEtextBox.Text), Convert.ToDouble(maxFloatIEEEtextBox.Text));
            if (calculator.DoCalculations())
            {
                CurrentFloatIEEEtextBox.Text = calculator.currentProccessedAverageFloat.ToString();
                RequiredAverageFloatIEEEtextBox.Text = calculator.reqAverageFloatOfSkins.ToString();
                CurrentFloat10SkinsIEEEtextBox.Text=calculator.averageFloatOfSkins.ToString();
                CurrentFloatIEEEtextBox.BackColor = Color.Green;
            }
            else
            {
                CurrentFloatIEEEtextBox.Text = calculator.currentProccessedAverageFloat.ToString();
                RequiredAverageFloatIEEEtextBox.Text = calculator.reqAverageFloatOfSkins.ToString();
                CurrentFloat10SkinsIEEEtextBox.Text = calculator.averageFloatOfSkins.ToString();
                CurrentFloatIEEEtextBox.BackColor = Color.Red;
            }
          


        }

        private void IEEEtextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

        }

     

        private void IEEEtextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void IEEEtextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void minFloatIEEEtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void maxFloatIEEEtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void RequiredFloatIEEEtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
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

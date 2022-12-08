using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFClibrary;

namespace AFC.Presenter
{
    public class CalulatorPresenter : Calulator
    {

        public List<double> skinsArr = new();
        public void Calulator()
        {
      
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
            var calculator = new IEEE754Calculator(skinsArr, Convert.ToDouble(RequiredFloatIEEEtextBox.Text), Convert.ToDouble(minFloatIEEEtextBox.Text), Convert.ToDouble(maxFloatIEEEtextBox.Text));
            if (calculator.DoCalculations())
            {
                CurrentFloatIEEEtextBox.Text = calculator.currentProccessedAverageFloat.ToString();
                RequiredAverageFloatIEEEtextBox.Text = calculator.reqAverageFloatOfSkins.ToString();
                CurrentFloat10SkinsIEEEtextBox.Text = calculator.averageFloatOfSkins.ToString();
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



    }
}

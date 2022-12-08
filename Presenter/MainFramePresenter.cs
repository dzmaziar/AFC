using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.DAO;
using AFClibrary;
using MySql.Data.MySqlClient;

namespace AFC.Presenter
{
    public class MainFramePresenter
    {
        
        public static void SelectGun(string Text, ComboBox DatacomboBox1)
        {
            string? nameOfGun = null;
            nameOfGun = SearchNameOnPage.searchOnPage(Text);
            if (nameOfGun == null)
            {
                return;
            }
            var collection = SelectGunCollection.SelectCollection(nameOfGun);
            var quality = SelectGunQuality.SelectQuality(nameOfGun);
            switch (quality)
            {
                case "Convert":
                    break;

                case "Classified":
                   SwitchGuns.Classified(collection,DatacomboBox1);
                    break;

                case "Restricted":
                   SwitchGuns.Restricted(collection,DatacomboBox1);
                    break;

                case "Mil-Spec":
                   SwitchGuns.Mil_Spec(collection,DatacomboBox1);
                    break;

                case "Industrial Grade":
                 SwitchGuns.Industrial(collection,DatacomboBox1);
                    break;

                case "Consumer Grade":
                   SwitchGuns.Consumer(collection,DatacomboBox1);
                    break;

                default:
                    break;
            }
        }

        public static void Counting(ComboBox DatacomboBox1, TextBox floatTextBox, TextBox dataTextBox1)
        {
            var minFloat = SearchMaxMinFloat.SearchMinFloat(DatacomboBox1);
            var maxFloat = SearchMaxMinFloat.SearchMaxFloat(DatacomboBox1);
            var floatNeed = float.Parse(floatTextBox.Text);
            string floatBuff = null;
            if (floatNeed < minFloat || floatNeed > maxFloat)
            {
                MessageBox.Show("Невозможно скрафтить такой скин, проверьте базу флоатов");
                return;
            }
            floatBuff = dataTextBox1.Text.ToString();
            List<double> floatList = new List<double>();
            floatList = (FloatHighLighter.HighLightFloats(floatBuff));
            string answer = null;

            double reqAverageFloat = Calculator.GetRequiredAverageFloat(floatNeed, minFloat, maxFloat);
            if (CheckFloatRange.checkRange(floatList, reqAverageFloat))
            {
                answer = Calculator.DoCalculations(floatList, floatNeed, minFloat, maxFloat);
                DoCalculation add = new DoCalculation(answer);
                add.Show();
            }
            else
            {
                MessageBox.Show("Невозможно скрафтить: не входит в средний диапазон флотов");
                return;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using AFCLibrary;
using Presenter.View;

namespace Presenter
{
    public class MainFramePresenter
    {
        private IMainFrameView _view;
        public MainFramePresenter(IMainFrameView view)
        {
            _view = view;
        }
        public  void SelectGun(string Text)
        {
            string[] comboBox = null;
            string nameOfGun = null;
            if (Text == "") return;
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
                 comboBox = SwitchGuns.Classified(collection);
                    _view.SetComboBox(comboBox);
                    break;

                case "Restricted":
                    comboBox = SwitchGuns.Restricted(collection);
                    _view.SetComboBox(comboBox);
                    break;

                case "Mil-Spec":
                    comboBox = SwitchGuns.Mil_Spec(collection);
                    _view.SetComboBox(comboBox);
                    break;

                case "Industrial Grade":
                    comboBox = SwitchGuns.Industrial(collection);
                    _view.SetComboBox(comboBox);
                    break;

                case "Consumer Grade":
                    comboBox = SwitchGuns.Consumer(collection);
                    _view.SetComboBox(comboBox);
                    break;

                default:
                    break;
            }
        }

        public void Counting()
        {
            var minFloat = SearchMaxMinFloat.SearchMinFloat(_view.GetSelectedItem());
            var maxFloat = SearchMaxMinFloat.SearchMaxFloat(_view.GetSelectedItem());
            var floatNeed = float.Parse(_view.GetFloatText());
            string floatBuff = null;
            if (floatNeed < minFloat || floatNeed > maxFloat)
            {
                _view.ViewMessageBox("Невозможно скрафтить такой скин, проверьте базу флоатов");
                return;
            }
            floatBuff = _view.GetdataText();
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
                _view.ViewMessageBox("Невозможно скрафтить: не входит в средний диапазон флотов");
                return;
            }

        }
    }
}

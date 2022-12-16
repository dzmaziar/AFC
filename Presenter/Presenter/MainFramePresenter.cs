using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using CalculationLibrary;
using Presenterr.View;
using System.ComponentModel;
using AFC.IPresenters;
using AFC.Repositories;


namespace Presenterr
{
    //enum Quality
    //{
    //    [Description("Classified")]
    //    Classified = 1,
    //    [Description("Restricted")]
    //    Restricted = 2,
    //    [Description("Mil-Spec")]
    //    MilSpec = 3,
    //    [Description("Industrial Grade")]
    //    Industrial = 4,
    //    [Description("Consumer Grade")]
    //    Consumer = 5
    //}

    public class MainFramePresenter:IMainFrame
    {
        private IMainFrameView _view;
        public MainFramePresenter(IMainFrameView view)
        {
            _view = view;
           
        }
        public string Counting()
        {
            var service = new SearchService();
            var minFloat = service.SearchMinFloat(_view.GetSelectedItem());
            var maxFloat = service.SearchMaxFloat(_view.GetSelectedItem());
            var floatNeed = float.Parse(_view.GetFloatText());
            var parsing = new ParsingPage();
            string floatBuff = null;
            if (floatNeed < minFloat || floatNeed > maxFloat)
            {
                _view.ViewMessageBox("Невозможно скрафтить такой скин, проверьте базу флоатов");
                return null;
            }
            floatBuff = _view.GetdataText();
            List<double> floatList = new List<double>();
            floatList = (FloatHighLighter.HighLightFloats(floatBuff));
            string answer = null;

            double reqAverageFloat = Calculator.GetRequiredAverageFloat(floatNeed, minFloat, maxFloat);

            if (parsing.CheckRange(floatList, reqAverageFloat))
            {
                answer = Calculator.CalculateCombinations(floatList, floatNeed, minFloat, maxFloat);

                return answer;
            }
            else
            {
                _view.ViewMessageBox("Невозможно скрафтить: не входит в средний диапазон флотов");
                return null;
            }

        }
        public  void SelectGun(string Text)
        {
            string[] comboBox = null;
            string nameOfGun = null;
            if (Text == "") return;
            ParsingPage search = new ParsingPage(_view);
           nameOfGun = search.searchOnPage(Text);
            if (nameOfGun == null)
            {
                return;
            }
            var selector = new SelectService();
            var collection = selector.SelectGunCollection(nameOfGun);
            var quality = selector.SelectGunQuality(nameOfGun);
            switch (quality)
            {
               
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

       
    }
}

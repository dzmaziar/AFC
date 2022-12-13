using Presenter.View;
using System;
using System.Collections.Generic;
using AFCLibrary;
namespace Presenter
{
    public class CalulatorPresenter
    {
        private ICalulatorView _view;
        public CalulatorPresenter(ICalulatorView view)
        {
            _view = view;
        }

        public void Calulator()
        { List<double> skinsArr = new List<double>();
            List<string> floatsArr = new List<string>();
            string requiredFloat, minFloat, maxFloat;
            skinsArr = _view.GetListOfCalculatorBox();
            floatsArr = _view.GetListOfFloats();
            requiredFloat = floatsArr[0];
            minFloat = floatsArr[1];
            maxFloat = floatsArr[2];
            
            var calculator = new IEEE754Calculator(skinsArr, Convert.ToDouble(requiredFloat), Convert.ToDouble(minFloat), Convert.ToDouble(maxFloat));
            if (calculator.DoCalculations())
            {
                _view.SetListOnTextBox(calculator.currentProccessedAverageFloat.ToString(), calculator.reqAverageFloatOfSkins.ToString(), calculator.averageFloatOfSkins.ToString(), Color.Green);
            }
            else
            {
                _view.SetListOnTextBox(calculator.currentProccessedAverageFloat.ToString(), calculator.reqAverageFloatOfSkins.ToString(), calculator.averageFloatOfSkins.ToString(), Color.Red);
            }
        }

    }

}


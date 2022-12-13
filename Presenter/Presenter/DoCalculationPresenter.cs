using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.View;

namespace Presenter
{
    public class DoCalculationPresenter
    {
        private IDoCalculationView _view;
        public DoCalculationPresenter(IDoCalculationView view)
        {
            _view = view;
        }

        public void DoCalculation(string Text)
        {
            var answer = Text;
            var answerArray = answer.Split('\n');
            var data = new List<string>();
            foreach (var line in answerArray)
            {
                data.Add(line);
            }
            _view.SetListOnGried(data);
        }
    }
}

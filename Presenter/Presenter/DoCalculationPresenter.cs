using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenterr.View;

namespace Presenterr
{
    public class DoCalculationPresenter
    {
        private IDoCalculationView _view;
        public DoCalculationPresenter(IDoCalculationView view)
        {
            _view = view;
        }
        public void GetCalculateResult(string Text)
        {
            var answer = Text;
            var answerArray = answer.Split('\n');
            var data = new List<string>();
            data.AddRange(answerArray);
            _view.SetListOnGried(data);
        }
    }
}

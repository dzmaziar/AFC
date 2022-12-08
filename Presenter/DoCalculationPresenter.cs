using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Presenter
{
    public class DoCalculationPresenter
    {
        public static void DoCalculation(string Text,DataGridView combinationDataGridView)
        {
            var answer = Text;
            var answerArray = answer.Split('\n');
            var data = new List<string>();
            foreach (var line in answerArray)
            {
                data.Add(line);
            }

            for (int i = 0; i < 10; i++)
            {
                combinationDataGridView.Rows.Add(data[i]);
            }
        }
    }
}

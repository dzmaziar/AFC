using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Presenter.View
{
   public interface ICalulatorView
   {
       List<double> GetListOfCalculatorBox();
        List<string> GetListOfFloats();
       void SetListOnTextBox(string currentAverage, string req, string averageOfSkins, System.Drawing.Color color );

     
       
   }
}

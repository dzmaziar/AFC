using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.View; 

namespace Presenter
{
    public class ViewProcessedDataPresenter
    {
        IViewDataProccess _view;
        public ViewProcessedDataPresenter(IViewDataProccess view)
        {
            _view = view;
        }
        public void ViewProcessedData(string Text)
        {
           
            var buff = SearchNameOnPage.searchOnPage(Text);  ;
            if (buff == "0")
            {
                return;
            }
            var floatBuff = Text;
            List<double> floatList = new List<double>();
            floatList = (FloatHighLighter.HighLightFloats(floatBuff));

            List<string> data = new List<string>();
            foreach (double d in floatList)
            {

                data.Add(d.ToString());
            }
            _view.SetData(buff, data);
          
        }



    }
}

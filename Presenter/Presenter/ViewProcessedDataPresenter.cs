using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenterr.View;
using CalculationLibrary;
using AFC.IRepository;
using AFC.IPresenters;

namespace Presenterr
{
    public class ViewProcessedDataPresenter:IProccessData
    {
        IViewDataProccess _view;
        IDbStandartActions _db;
        public ViewProcessedDataPresenter(IViewDataProccess view)
        {
            _view = view;
        }
        public void ViewProcessedData(string Text)
        {
            ParsingPage search = new ParsingPage(_view);
            var buff = search.searchOnPage(Text);  ;
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

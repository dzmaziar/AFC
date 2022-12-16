using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Presenterr.View;
using AFC.Repositories;
using AFC.IPresenters;

namespace Presenterr
{
    public class ParsingPage:IParsing
    {
        IMainFrameView _view;
        IViewDataProccess _viewDataProccess;
        public ParsingPage()
        {
           
        }
        public ParsingPage(IMainFrameView view)
        {
            _view = view;
        }
        public ParsingPage(IViewDataProccess viewDataProccess)
        {
            _viewDataProccess = viewDataProccess;
        }
        public bool CheckRange(List<double> floatList, double average)
        {
            var max = floatList.Max();
            var min = floatList.Min();
            return average <= max && average >= min;
        }
        public  string searchOnPage(string Text)
        {
            var service = new SearchService();
            var start = service.SearchPrefixName(Text);
            int a = 0;
            for (int j = 0; j < start.Count; j++)
            {
                a = Text.IndexOf(start[j]);
                if (a != -1 && a != 0)
                {
                    break;
                }
            }
            string buff = null;
            var name = Text;
            if (name == "" && name == "0")
            {
                _view.ViewMessageBox("Нет скина на странице");
                return "0";
            }
            if (a != 0 && a != -1)
                {
                    string r = name.Substring(a);
                    buff = name.Substring(a, r.IndexOf("(") - 1);
                }
                return buff;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFClibrary;

namespace AFC.Presenter
{
    internal class ViewProccesPresenter
    { 
        public static void ViewProcces(string Text,DataGridView dataGridView1)
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

            for (int i = 0; i < data.Count; i++)
            {

                dataGridView1.Rows.Add(buff, data[i]);
            }
        }



    }
}

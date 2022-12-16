using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.IPresenters
{
   public interface IParsing
    {
        public bool CheckRange(List<double> floatList, double average);
        public string searchOnPage(string Text);


    }
}

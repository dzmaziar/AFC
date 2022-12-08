using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Presenter
{
    internal class CheckFloatRange
    {
        public static bool  checkRange(List<double> floatList, double average)
        {
           var max = floatList.Max();
            var min = floatList.Min();
            if (average <= max && average >= min)
            {
                return true;
            }

            return false;
        }

    }
}

using System.Collections.Generic;
using System.Linq;

namespace Presenter
{
    public class CheckFloatRange
    {
        public static bool  checkRange(List<double> floatList, double average)
        {
           var max = floatList.Max();
            var min = floatList.Min();
            return average <= max && average >= min;
        }

    }
}

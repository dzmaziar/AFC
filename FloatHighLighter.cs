using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace AFC
{
    internal class FloatHighLighter
    {
        private const String FLOAT_VALUE = "Float: ";

        public static List<double> HighLightFloats(String pageCopy)
        {
            List<double> floatArray = new List<double>();
            int stringIndex = pageCopy.IndexOf(FLOAT_VALUE);
            int index = 0;
            while (stringIndex >= 0)
            {
                string tempFloat = "";
                index = stringIndex + 7;
                char tempchar;
                for (int i = index; i < pageCopy.Length; i++)
                {
                    tempchar = pageCopy[i];
                    if (tempchar == '.' || tempchar == '0' || tempchar == '1' || tempchar == '2' || tempchar == '3' || tempchar == '4' || tempchar == '5' || tempchar == '6' || tempchar == '7' || tempchar == '8' || tempchar == '9')
                    {
                        tempFloat += pageCopy[i];
                    }
                    else break;
                }
                if (tempFloat != "")
                {
                    double temp = Convert.ToDouble(tempFloat);
                    floatArray.Add(temp);
                }
                stringIndex = pageCopy.IndexOf(FLOAT_VALUE, index);
            }
            return floatArray;
        }
    }
}

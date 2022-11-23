using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC
{
    internal class IEEE754Calculator
    {
        public List<double> skinsArr;
        public double floatYouNeed;
        public double minFloat;
        public double maxFloat;
        public double averageFloatOfSkins;
        public double currentProccessedAverageFloat;
        public double reqAverageFloatOfSkins;

        //при каждом изменении данных в полях UI удалять  текущуий экземпляр и создавать новый с помощью конструктура,
        //после чего вызвать метод DoCalculations
        public IEEE754Calculator(List<double> skinsArr, double floatYouNeed, double minFloat, double maxFloat)
        {
            this.skinsArr = skinsArr;
            this.floatYouNeed = floatYouNeed;
            this.minFloat = minFloat;
            this.maxFloat = maxFloat;
        }

        public void SetMinFloat(double minFLoat)
        {
            this.minFloat = minFLoat;
        }
        public void SetMaxFloat(double maxFLoat)
        {
            this.maxFloat = maxFLoat;
        }
        public void SetFloatYouNeed(double floatYouNeed)
        {
            this.floatYouNeed = floatYouNeed;
        }

        public bool DoCalculations()
        {
            double tempSum = 0;
            for (int i = 0; i < skinsArr.Count; i++)
            {
                tempSum += skinsArr[i];
            }
            //соответсвие с UI 
            averageFloatOfSkins = tempSum / skinsArr.Count; //current float of 10 skins

            currentProccessedAverageFloat =Convert.ToSingle( averageFloatOfSkins * (maxFloat - minFloat) + minFloat);  //Current float

            reqAverageFloatOfSkins = Calculator.GetRequiredAverageFloat(floatYouNeed, minFloat, maxFloat);  //Required average float

            //если true то подсветить поле "Current float" зеленым else красным
            if (currentProccessedAverageFloat == Convert.ToSingle(floatYouNeed))
            {
                return true;
            }
            else return false;
        }
    }
}
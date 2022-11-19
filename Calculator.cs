using System;



namespace AFC
{
    internal class Calculator
    {
        public static double GetRequiredAverageFloat(double floatYouNeed, double minFloat, double maxFloat)
        {
            return Convert.ToSingle((floatYouNeed - minFloat) / (maxFloat - minFloat));
        }
        public static double GetAverageFloatOfSkins(List<double> skins)
        {
            double tempSum = 0;
            for (int i = 0; i < skins.Count; i++)
            {
                tempSum += skins[i];
            }
            return Convert.ToSingle(tempSum/skins.Count);
        }
    }
}

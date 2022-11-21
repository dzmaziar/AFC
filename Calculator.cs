using System;



namespace AFC
{
    internal class Calculator
    {
        public static double GetRequiredAverageFloat(double floatYouNeed, double minFloat, double maxFloat)
        {
            floatYouNeed = Convert.ToSingle(floatYouNeed);
            minFloat = Convert.ToSingle(minFloat);
            maxFloat = Convert.ToSingle(maxFloat);
            //return Convert.ToSingle((floatYouNeed - minFloat) / (maxFloat - minFloat));
            return (floatYouNeed - minFloat) / (maxFloat - minFloat);
        }
        public static double GetAverageFloatOfSkins(List<double> skins)
        {
            double tempSum = 0;
            for (int i = 0; i < skins.Count; i++)
            {
                tempSum += skins[i];
            }
            tempSum = Convert.ToSingle(tempSum);
            return Convert.ToDouble(tempSum/skins.Count);
        }
        public static void DoCalculations(List<double> skinsArray, double floatYouNeed, double minFloat, double maxFloat, String path) //Delete "path" when UI added
        {
            double reqFloat = Convert.ToSingle(GetRequiredAverageFloat(floatYouNeed, minFloat, maxFloat));
            int N = skinsArray.Count;
            CombinationGenerator gen = new CombinationGenerator(N);
            int[] indexArr = new int[N];
            for (int i = 0; i < N; i++)
            {
                indexArr[i] = i + 1;
            }
            List<double> tempCombination = new List<double>();
            double averageFloatOfCombination = 0;
            int counter = 0;
            while(gen.GenerrateCombination(indexArr))
            {
                tempCombination.Clear();
                counter++;
                if (counter % 5000000 == 0)
                {
                    Console.WriteLine(counter); 
                }
                for (int i = 0; i < 10; i++)
                {
                    tempCombination.Add(skinsArray[indexArr[i]-1]);       //[i]-1 because filling was [i]+1
                }
                averageFloatOfCombination = GetAverageFloatOfSkins(tempCombination);
                if (Convert.ToSingle(averageFloatOfCombination) == reqFloat)
                {
                    String str = String.Join("\n", tempCombination);
                    DAO.WriteToFile(path, str);                                     //When UI added show combination in UI
                    Console.WriteLine("Sucess!\n" + str + "\n");                                         //Delete when UI added
                }
            }
        } 
    }
}

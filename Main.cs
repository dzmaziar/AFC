using AFC;
using System;
using System.Runtime.ConstrainedExecution;

String pageCopy = "pageCopy.txt";
String floats = "Combinations.txt";
List<double> floatArr = FloatHighLighter.HighLightFloats(DAO.ReadFromFile(pageCopy));
Console.WriteLine(String.Join("\n", floatArr));
Calculator.DoCalculations(floatArr, 0.25, 0, 1, floats);
namespace AFC
{  
}



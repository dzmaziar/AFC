using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC
{
    internal class DAO
    {
        public static String ReadFromFile(String path)
        {
            String text = File.ReadAllText(path);
            return text;
        }
        public static void WriteToFile(String path, String text)
        {
            File.AppendAllText(path, text);
        }
    }
}

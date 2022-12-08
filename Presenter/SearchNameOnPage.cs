using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Presenter
{
    internal class SearchNameOnPage
    {
        public static string searchOnPage(string Text)
        {
            var nameOnPage = "AK-47 |,AWP |,MP9 |,MAC-10 |,Desert Eagle |,M4A4 |,M4A1-S |,Glock-18 |,USP-S |,Negev |,P2000 |,Five-Seven |,P250 |,Dual Berettas |,Tec-9 |,CZ75-Auto |,PP-Bizon |,MP7 |,FAMAS |,P90 |,Sawed-Off |,R8 Revolver |,M249 |, Galil AR |,XM1014 |,MAG-7 |,G3SG1 |,AUG |,SG 553 |,SCAR 20 |,SSG 08 |";
            var temp = "(";
            var names = nameOnPage.Split(',');
            var start = 0;
            var finish = 0;
            string? buff = null;
            var count = names.Length;
            var name = Text;
            if (name == "" && name == "0")
            {
                MessageBox.Show("На странице нет оружий!");
                return "0";
            }
            for (int i = 0; i < count; i++)
            {
                start = name.IndexOf(names[i]);
                if (start != 0 && start != -1)
                {
                    string r = name.Substring(start);
                    buff = name.Substring(start, r.IndexOf(temp) - 1);
                    break;
                }
            }
            return buff;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Presenter
{
    public class SearchNameOnPage
    {
        public static string searchOnPage(string Text)
        {
            var search = new SearchPrefixnameService();
            var start = search.SearchPrefixNameOnPage(Text);
            var finish = 0;
            string buff = null;
            var name = Text;
            if (name == "" && name == "0")
            {
                MessageBox.Show("На странице нет оружий!");
                return "0";
            }
            if (start != 0 && start != -1)
                {
                    string r = name.Substring(start);
                    buff = name.Substring(start, r.IndexOf("(") - 1);
                }
                return buff;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.IRepository
{
    public interface ISearchService
    {
        public List<string> SearchPrefixName(string text);
        public double SearchMaxFloat(string selectedItem);
        public double SearchMinFloat(string selectedItem);
    }
}

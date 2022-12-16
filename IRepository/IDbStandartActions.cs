using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.IRepository
{
   public interface IDbStandartActions
    {
        public List<string[]> GetAllItems();
        public DataTable SearchInDB(string text);
        public void AddToDb();
    }
}

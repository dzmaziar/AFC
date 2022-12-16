using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.IRepository
{
    public interface IAddInDb
    {
       public List<string> GetArrayOfParameters();
    }
}

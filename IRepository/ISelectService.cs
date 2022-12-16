using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.IRepository
{
    public interface ISelectService
    {
        public string SelectGunCollection(string nameOfGun);
        public string SelectGunQuality(string nameOfGun);
    }
}

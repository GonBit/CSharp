using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapon : IShootable
    {
        public string _brand;

        //Construtor
        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return "";
        }

        public virtual string ToString()
        {
            return _brand;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public interface IMoveable
    {
        public string Move();
        public string Move(int times);
    }
}

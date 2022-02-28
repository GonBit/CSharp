using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Method
    {
        
        public static int GetStones(int totalStones)
        {
            /*
            int pounds = totalStones;
            int stones;
            stones =  pounds / 14;           

            return stones;
            */

            return totalStones / 14; //SIMPLIFIED
        }
        

        public static int GetPounds(int totalPounds)
        {
            /*
            int pounds = totalPounds;
            int leftPounds = pounds % 14;

            return leftPounds;
            */

             return totalPounds % 14; //SIMPLIFIED
        }
       
    }

}

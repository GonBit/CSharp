using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Method
    {
        public static void NotMain(string[] args)
        {

            int tStones = 0;
            var stones = GetStones(tStones);

            try
            {
                GetStones(8);
                GetStones(-18);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }        


        public static int GetStones(int totalStones)
        {
            /*
            int pounds = totalStones;
            int stones;
            stones =  pounds / 14;           

            return stones;
            */

            //SIMPLIFIED            
                
            if( totalStones < 0)
                throw new Exception("Invalid Input");
            else return totalStones / 14;
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

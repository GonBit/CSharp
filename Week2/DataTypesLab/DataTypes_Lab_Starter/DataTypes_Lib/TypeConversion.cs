using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            checked
            { 
           
                return (short)num;
          
            }

        }

        public static long FloatToLong(float num)
        {
            num = (float)Math.Round(num, MidpointRounding.AwayFromZero);
            //Midpoint values are rounded to the next number away from zero.
            //For example, 3.75 rounds to 3.8, 3.85 rounds to 3.9, -3.75 rounds to -3.8, and -3.85 rounds to -3.9.
            //This form of rounding is represented by the MidpointRounding.AwayFromZero enumeration member.
            return (long)num;
            // return Convert.ToInt64(num);            
            
        }
    }
}

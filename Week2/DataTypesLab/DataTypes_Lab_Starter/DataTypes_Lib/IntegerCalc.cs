using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            checked //checked to catch the overflow
            {
             
                return num1 + num2;             

            }
            
        }

        public static int Subtract(int num1, int num2)
        {
            checked //same concept as before
            {
               
                return num1 - num2;
               
            }            
            
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
            throw new NotImplementedException();
        }

        public static int Divide(int num1, int num2)
        {

            if (num2 == 0)
            {
                throw new ArgumentException("Can't divide by zero");
            }
            else
                return num1 / num2;              
 
        }

        public static int Modulus(int num1, int num2)
        {
            if(num2 == 0)
            {

                throw new ArgumentException("Can't modulo by zero");

            }
            else return num1 % num2;            
        }
    }
}

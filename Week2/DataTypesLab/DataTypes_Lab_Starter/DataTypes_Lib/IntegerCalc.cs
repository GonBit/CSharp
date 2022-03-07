using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static double Add(double num1, double num2)
        {
            checked //checked to catch the overflow
            {             
                return num1 + num2;         
            }            
        }
        public static double Subtract(double num1, double num2)
        {
            checked //same concept as before
            {               
                return num1 - num2;               
            }           
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
            throw new NotImplementedException();
        }

        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Can't divide by zero");
            }
            else
                return num1 / num2;            
        }
        public static double Modulus(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new ArgumentException("Can't modulo by zero");
            }
            else return num1 % num2;            
        }
    }
}

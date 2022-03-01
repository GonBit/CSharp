using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(long n)
        {
            long factorial = 1; //Counts as the number that it has to multiply for

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
            
            throw new NotImplementedException();
        }

        public static float Mult(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}

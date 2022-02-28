using System;
using System.Collections.Generic;
using System.Linq;

namespace TestFirstExercises
{
    public class Methods
    {
        // implement this method so that it returns true if x is greater than or equal to y
        public static bool GreaterEqual(int x, int y)
        {
            if (x >= y)
            {             
                return true;
            }
            
            return false;           
        }

        // Implement this method so that it take an int as an input,
        // squares it, adds 101, divides the result by 7, then subtracts 4.  
        // Return a double rounded to 3 decimal places.
        public static double BODMAS(int inputNumber)
        {
            double result = inputNumber;
            result = result * result;
            result = result + 101;            
            result = result / 7;
            result = result - 4;
            

            result = Math.Round(result, 3);

            return result;
        }

        // implement this method so that it returns true if num is even, otherwise false
        public static bool EvenOdd(int num)
        {
            
            if (num % 2 == 0) 
            {

                return true;
            
            }

            return false;
        }

        // implement this method so that it returns 
        // the sum of all numbers between 1 and n inclusive 
        // that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum2, sum5, sum25;

            // sum2 is sum of numbers
            // divisible by 2
            sum2 = ((max / 2) * (4 + (max / 2 - 1) * 2)) / 2;

            // sum5 is sum of number
            // divisible by 5
            sum5 = ((max / 5) * (10 + (max / 5 - 1) * 5)) / 2;

            // sum10 of numbers divisible
            // by 2 and 5
            sum25 = ((max / 10) * (20 + (max / 10 - 1) * 10)) / 2;

            max = sum2 + sum5 - sum25;
            return max;

        }

        // implement this method so it returns true if input is "password"
        // regardless of case
        public static bool CheckInput(string input)
        {
            //String Comparation indiferent of Case
            bool contains = input.IndexOf("password", StringComparison.OrdinalIgnoreCase) >= 0;                  

            return contains;
        }

        // implement this method so it returns the sum
        // of all the numbers in the list
        public static int SumList(List<int> list)
        {
             
            //LINQ
            return list.Sum();
        }
    }
}
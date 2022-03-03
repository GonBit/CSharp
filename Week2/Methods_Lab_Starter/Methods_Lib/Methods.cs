using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {

            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException( "totalDays must not be negative");
            }
            var days = totalDays % 7;
            var weeks = totalDays / 7;
         
            return (weeks, days);           

        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

        public static (int square , int cube , double squareRoot) PowersRoot(int number) 
        {
            var square = number * number;
            var cube = number * number * number;
            var squareRoot = Math.Sqrt(number);          

            return (square, cube, squareRoot);

        }

    }
}

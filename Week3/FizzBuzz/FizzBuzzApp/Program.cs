using System;
using System.Text;

namespace FizzBuzzApp;

public class Program
{
    public static void Main(string[] agrs)
    {
        //Div by 3 - fizz
        //Div by 5 - buzz
        //Div by 3 and 5 - fizzbuzz
        int max = 30;

        for (int i = 1; i <= max; i++)
        {
            Console.WriteLine(FizzBuzz(i));
        }
    }

    public static string FizzBuzz(int i)
    {
        /*
        if (i % 3 == 0 && i % 5 == 0)
             return ("FizzBuzz");

         if (i % 3 == 0)        
             return ("Fizz");        

         if (i % 5 == 0)        
             return ("Buzz");             

         return i.ToString();
        */
        return (i % 15 == 0) ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString();      
           
    }
}
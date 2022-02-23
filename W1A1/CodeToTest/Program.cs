using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 0;
        //Console.ReadLine(timeOfDay);
        
        var greeting = Greeting(timeOfDay);
        Console.WriteLine(greeting);

    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;

        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Top of the morning";
        }

        else if (timeOfDay > 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon";
        }

        else if (timeOfDay < 5 && timeOfDay >= 0 || timeOfDay > 18 && timeOfDay < 24)
        {
            greeting = "Good evening";
        }
        else
        { 
            greeting = "Invalid Input";
        }

       

        return greeting;
    }
}
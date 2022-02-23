using System;

namespace CodeToTest;

public class Program 
{
    static void Main(string[] args)
    {
        int timeOfDay = 12;
        //Console.ReadLine(timeOfDay);
        
        var greeting = Greeting(timeOfDay);
        Console.WriteLine(greeting);

    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;
        if (timeOfDay >= 5 && timeOfDay <= 12)
        {

            greeting= "Top of the morning" ;

        }
        else if (timeOfDay >= 13 && timeOfDay <= 18)
        {

            greeting = "Good afternoon";

        }
        else
        {

            greeting = "Good evening";

        }

        return greeting;
    }
}
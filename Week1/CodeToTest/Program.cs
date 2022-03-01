using System;
namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 0;
        //Console.ReadLine(timeOfDay);
        
        var greeting = Greeting(timeOfDay);
        //Console.WriteLine(greeting);

        try
        {
            Console.WriteLine(Greeting(5));
            Console.WriteLine(Greeting(35));

        }
        catch (ArgumentOutOfRangeException ex) {

            //Console.WriteLine("Invalid Input");
            Console.WriteLine(ex.Message);
        }
        

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
            throw new ArgumentOutOfRangeException("Invalid Input");
        }               

        return greeting;
    }

    

    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;

        switch (ageOfViewer)
        {
            case < 0:
                result = "Invalid age.";
                break;

            case <= 12:
                if (ageOfViewer == 12)
                {
                    result = "U, PG , 12 & 12A films are available.";
                }
                else
                    result = "U, PG films are available.";
                break;

            case < 18:
                if (ageOfViewer >= 15)
                {
                    result = "U, PG, 12, 12A & 15 films are available.";
                }
                else
                    result = "U, PG , 12 & 12A films are available.";
                break;

            case >= 18:
                result = "All films are available.";
                break;  
                
            default:
                result = "Invalid age.";
                break;
        }

        return result;
    }
}


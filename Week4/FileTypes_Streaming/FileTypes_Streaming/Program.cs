#define TEST

using System;
using System.Diagnostics;


namespace FileTypes_Streaming;
public class Program
{
    public static void Main(string[] args)
    {
        #region Trace & Debug
        /*
        //Logging to the console
        //Console.WriteLine($"This is being logged at {DateTime.Now}");

        TextWriterTraceListener twtl = new TextWriterTraceListener(File.Create("Traceoutput.txt"));
        Trace.Listeners.Add(twtl);
        //Logging to Visual Studio
        int total = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
            total+= i;
            Debug.WriteLine($"Debug the value of I is {i}");//Gives you information about debug            
            Trace.WriteLine($"Trace the value of I is {i}");//Being used about the performance of the system
            Debug.WriteLineIf(i == 2, $"\nReached maximum value of i: {i} at {DateTime.Now}");
            Trace.Assert(i > 0, $"i is not greater than zero: {i}");
        }
        Trace.Flush();
        */
        #endregion

        #region Conditional Compiling
        /*
        Console.WriteLine("Starting app");

#if DEBUG
        Console.WriteLine("This is debug code");
#endif

#if TEST
        Console.WriteLine("This is a test");
#endif
        Console.WriteLine("Closing App");
        */
        #endregion

        #region Character Enconding
        /*
        //This shows the ASCII values of any string
        string input = "";
        bool @continue;
        do
        {
            Console.WriteLine("Please input a string");
            input = Console.ReadLine();
            foreach (var item in input)
            {
                Console.WriteLine(Convert.ToInt32(item));
            }
            Console.WriteLine("\"Yes\" to continue.");
            @continue = Console.ReadLine().ToLower() == "yes";
        } while (@continue);*/
        #endregion

        #region

        #endregion

    }
}
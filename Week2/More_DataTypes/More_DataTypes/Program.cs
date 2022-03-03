using System;
using System.Diagnostics;
using System.Text;

namespace More_DataTypes;

public enum suits
{
    HEARTS =3, CLUBS/* =4*/, DIAMONDS/* =5*/, SPADES/* =6*/ //they have an underlying integer value of 0
}

public enum Size
{ 

    SMALL = 10, MEDIUM =25, LARGE = 100

}
public static class Program
{
    static void Main (string[] args)
    {   
       /* var myString = "C# list fundamental";
        Console.WriteLine(StringBuilderExercise(myString));

        
        
        //Concat and Interpolation
        var spartaString = String.Concat("This", "is", "Sparta");
        StringInterpolation("Nish");

        var num1 = 2;
        var num2 = 3;

        var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
        Console.WriteLine(fString);

        var fString2 = $"That will be {num1 / 3.0:C}, please"; //C formats to currency
        var fString3 = $"You've recieved {1 / 10.0:P} in your test"; //P formats it to percentage
        Console.WriteLine(fString2);
        Console.WriteLine(fString3);
        ParsingStrings();
        OneDArray();
        TwoDArray();

        //2D array
        
        char[,] gridTwo =
        {
            { 'a','b'},
            { 'c','d'},
            { 'e','f'},
            { 'g','h'},

        };
        foreach (char c in gridTwo)
        { 
            Console.WriteLine(c);//itterate in column instead of line
        }
        //research upperbound and lowerbound //nested for loop
        //loads of sort algorithms*/

        //One way to create a jagged array
        
        string[] trainingGroup = { "Laura", "Steven", "James", "Jab", "Ned" };
        string[][] spartaAcademy = new string[][]
        {
             new string[]{ "Marian", "Goncalo", "Seb", "Stanni" , "David", "Gaurav"},
             trainingGroup
        };
        foreach (string[] arr in spartaAcademy)
        {
            Console.WriteLine(" ");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        /*
        DateTimeMethods();
        var birthDay = new DateTime(1989, 11, 2); //year time day
        Console.WriteLine(birthDay);
        Console.WriteLine(birthDay.ToString("y-M-d"));
        Console.WriteLine(birthDay.ToString("M-d-y"));
        Console.WriteLine(birthDay.ToString("dd-MMM-yy")); // abreviation of Month
        Console.WriteLine(birthDay.ToString("dddd-MMMM-yyyy")); //MMMM-full months dddd- Thursday

        TimeSpan myAge = DateTime.Now - birthDay;
        //Console.WriteLine(myAge);
        var myAgeInYears = myAge.Days / 365.25;//using .Days to extract days out of myAge
        Console.WriteLine($"Nish is {myAgeInYears:N1} years old to one decimal point");
        Console.WriteLine($"Nish is {myAgeInYears:N0} years old");

        //DateOnly
        var myDate = new DateOnly(1989, 11, 2);
        Console.WriteLine(myDate);//presents date in a nice format
        var today = DateTime.Now;
        DateOnly today1 = DateOnly.FromDateTime(today);
        Console.WriteLine(today); // gives date with time
        Console.WriteLine(today1);// this removes to date without time

        //Stopwatch
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        long total = 0;
        for (int i = 0; i < int.MaxValue; i++)
        {

            total += i;
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        Console.WriteLine(stopwatch.ElapsedTicks);
        

        //Enum();

        //var mediumValue = (int)Size.MEDIUM;
        //var mySize = (Size)50;

        var anotherSuit = Enum.Parse(typeof(suits), "CLUBS"); //casting a club to one of ENUM */


    }

    public static void Enums()
    { 
        suits theSuit = suits.HEARTS;
        
        switch (theSuit)
        {
            case suits.SPADES:
                Console.WriteLine($"Suit is {suits.SPADES}");

                break;
            case suits.HEARTS:
                Console.WriteLine($"Suit is {suits.HEARTS}");

                break;
            default:
                Console.WriteLine("Goodbye");
                break;
        }


    }

    public static void DateTimeMethods()
    { 
    
        var now = DateTime.Now;
        Console.WriteLine($"The time now is : {now}");
        //Console.WriteLine($"In ticks this is {now.Ticks}");//10M ticks == 1 sec Ticks are used for precision
        //Console.WriteLine(DateTime.MinValue); //01/01/0001 00:00:00
        //Console.WriteLine(DateTime.MaxValue); //31/12/9999 23:59:59

        //Unix Epoch 1/1/1970
        //Overflow of Unix Epoch Look for Year 2038 problem

        var tomorrow = now.AddDays(1);
        Console.WriteLine(tomorrow);
        

    }

    public static void JaggedArray()
    {
        int[][] intJArray = new int[2][];
        intJArray[0] = new int[4];
        intJArray[1] = new int[2];

        //[][][3][]
        //[5][]
        intJArray[0][2] = 3;
        intJArray[1][0] = 5;


    }
    public static void TwoDArray()
    {
        //0  1
        //[ ][ ] 0
        //[ ][ ] 1
        //[ ][ ] 2 
        //[ ][ ] 3
        int[,] grid = new int[2, 4];  //2 col 4 rows 2by4
        grid[0, 0] = 6;
        grid[1, 1] = 8;
        grid[1, 3] = 10;

        //[6][ ]
        //[ ][8]
        //[ ][ ]
        //[ ][10]
    }
    public static void OneDArray() 
    {
        //[][][][][]
        int[] myIntArray = { 12, 34, 23, 45, 56 }; //declared and initialised
        var traineesArray = new string[] { " bla", "bla" }; //declared and initialised using var
        var traineesArray2 = new string[3];
        Array.Reverse(myIntArray);
        Array.ForEach(myIntArray, x => Console.WriteLine(x));
        
        myIntArray.OrderBy(x => x);//ascending
        myIntArray.OrderByDescending(x => x);

        //replace the values of the traineesArray with new values
        traineesArray[0] = "Jab";
        traineesArray[1] = "ble";
    }

   

    //Parsing
    public static void ParsingStrings() 
    {
        /*
        Console.WriteLine("How many apples");
        string input = Console.ReadLine();
        int numApples = Int32.Parse(input);//changes the string to integer
        Console.WriteLine($"{numApples} apples");*/
        bool isSuccess;
        do
        {

            Console.WriteLine("How many apples");
            string input = Console.ReadLine();
            isSuccess = Int32.TryParse(input ,out int numApples);//TryParse super useful for applications that take inputs
            Console.WriteLine($"{numApples} apples");

        } while (isSuccess);

        Console.WriteLine("Invalid Number");
        
    }

    //Interpolation
    public static void StringInterpolation(string str)
    { 
        Console.WriteLine("My name is : " + str + " using +");// concatenation
        Console.WriteLine($"My name is {str} using interpolation"); // the $ indicates interpolation
    
    }
    
    //StringBuilder
    private static string StringBuilderExercise(string myString)
    {
        //Using String Builder
        var trimmedUpString = myString.Trim().ToUpper();
        var nPos = trimmedUpString.IndexOf('N');
        StringBuilder sb = new StringBuilder(trimmedUpString);
        sb.Replace('L', '*').Replace('T', '*');
        sb.Remove(nPos + 1, sb.Length - nPos - 1);

        return sb.ToString();        

    }

}



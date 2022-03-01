using System;

namespace ExceptionsApp;

public class Program {

    public static void Main(string[] args) {

        string text;
        string fileName = "";

        /* You can catch any Expection but it's too vague
        //catches the exception created earlier (FileNotFound) and handles it next
        try
        {
            text = File.ReadAllText(fileName);
            Console.WriteLine(text);
        }
        catch (FileNotFoundException ex)
        { 

            Console.WriteLine("File not found " + fileName);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine("You gave me a empty file name");
        }
        finally
        {

            Console.WriteLine("I run whatever happens");
        }*/
        try
        {
            Console.WriteLine("82" + Grade(82));
            Console.WriteLine("-23" + Grade(-23));
            Console.WriteLine("123" + Grade(123));
        }
        catch (ArgumentOutOfRangeException ex)
        {

            Console.WriteLine("Invalid data");
            Console.WriteLine(ex.Message);
            //throw; is in Grade
        }
        catch (Exception ex)
        {

            Console.WriteLine("Is above 100");
            Console.WriteLine(ex.Message);
            //throw; is in Grade
        }


        int num1 = 5;
        int num2 = 0;
        try
        {
            Console.WriteLine(num1 / num2);

        }
        catch(DivideByZeroException ex) {
            Console.WriteLine(ex.Message);
            num2 = 1;
            //throw;
        }
        

        //all methods can throw exceptions regardless of the type
    }

    public static string Grade(int mark) {

        if (mark < 0 || mark > 100) {
            throw new ArgumentOutOfRangeException("Mark: " + mark + "allowed range 0-100"); 
        }
        return mark >= 65 ? (mark >= 85 ? "Distinticon" : "Pass") : "Fail";
        

    }

}
using System;
namespace Operators;

public class Program {

    public static void Main(string[] args) {
        /*
        int x = 5;
        int y = 5;
        int a = x++; //post fix operation
        int b = ++y; //the timing of increment is first than the x++ pre fix operation    

        for (int i = 0; i <= 5; ++i)
        {

            Console.WriteLine(i);
        }
        

        var c = 5 / 2; //2 int
        var d = 5.0 / 2; //2.5 double
        var e = 5 / 3; //1 int

        double f = 5 / 2; //because it's storing an int it will return still 2 but we're just storing it as a double
        
        //Sebs bday is 23 days from now. Put it in the format of days and week

        var daysInAWeek = 7;
        var daysToBday = 23;
        var weeksToBday = daysToBday / daysInAWeek;
        var days = daysToBday % daysInAWeek;

        Console.WriteLine("Weeks: " + weeksToBday + " Days: " + days);
        


        // Sprite Running animation
        const int NUM_ROWS = 2;
        const int NUM_COLUMNS = 5;

        bool running = true;
        int row = 0;
        int column = 0;
        int spriteNo = -1;

        while (running) {

            ++spriteNo;
            spriteNo = spriteNo % (NUM_ROWS * NUM_COLUMNS); 
            row = spriteNo / NUM_COLUMNS;
            column = spriteNo % NUM_COLUMNS;        
            
        }
         

        int j = 5, k = 3, m = 4;
        m += +j++ + ++k;  //4 + (5 + 4) = 13;
        

        bool isWearingParachute = false;

        if (isWearingParachute & JumpOutOfAirplane()) //short circuting statement because it doesnt to the right side because the left side is false //& checks both sides //&&only the left side
        {
            Console.WriteLine("You've jumped");
        
        }

        string greeting = "All right";
        if (greeting != null && greeting.ToLower().StartsWith('a')) {

            Console.WriteLine(greeting + " starts with 'a'");
        }*///END OF COMMENT 



    }

    private static bool JumpOutOfAirplane()
    {
        Console.WriteLine("Jump");
        return true;

    }

    public static bool EvenOdd(int num) {  //return true if its even false if its odd  
        
        if (num % 2 == 0) {

            return true;
        }
        
        return false;       
    
    }

    public static int FinSumDiv3And5(int n) {

        // it will add up all numbers between 1 and n inclusive
        // if divisible by 3 or 5
        // and return this sum

        //return Enumerable.Range(1, n + 1).Where(c => c % 5 == 0 || c => 3 == 0).Sum();

        int sum = 0;

        for (int i = 1; i <= n; i++) {

            if (i % 3 == 0 || i % 5 == 0) {

                sum = sum + i;
                
            }           
        
        }

        return sum;
    }


    
}
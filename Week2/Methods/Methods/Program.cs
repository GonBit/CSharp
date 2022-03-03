using System;

namespace Methods;

public class Methods 
{
    public static void Main(string[] args)
    {
        /*
        //Seeding with the current time in ticks
        var rng = new Random();
        var rngSeeded = new Random(42);
        var between1And10 = rngSeeded.Next(1,11);
        Console.WriteLine(between1And10); //result 7

        var rollDice1 = rng.Next(1, 7);
        var rollDice2 = rng.Next(1, 7);
        var rollDice3 = rng.Next(1, 7);       

        Console.WriteLine($"{rollDice1} {rollDice2} {rollDice3} {rollDice1 + rollDice2 + rollDice3}");
        *///End of COMmENT

        //int y = 10;
        // var result = DoThis(y, "Sad"); //y is assigned to x from the DoThis method - y holds its value while x doesn't
        //var result1 = DoThis(y);
        //Console.WriteLine(result1);
        //OrderPizza(pizzaToppings);
        //Console.ReadLine();

        //bool isLarge;
        //var result = DoThis(10/*int x*/, "Here's a string"/*string y*/, out isLarge/*bool z*/); //out passes by reference
        //Console.WriteLine(isLarge);

        var myTuple = ( fName:"Liam", lName:"Gallangher", age:49 );
        //Console.WriteLine(myTuple);
        //Console.WriteLine(myTuple.lName);

        (string fName, string lName, int age) myTuple2 = ("Noel","Gallangher", 55);// another way of initialising
        var noel = myTuple.fName;
        var myTuple3 = ("Bon", noel);



        //Tuple
        var result = ConvertPoundsToStones(98);
        Console.WriteLine(result);
    }

    public static (int,int)/* a method tha returns a tuple */ ConvertPoundsToStones(int pounds)
    {
        const int poundsInAStone = 14;
        var st = pounds / poundsInAStone;
        var lb = pounds % poundsInAStone;

        //or return as a variable
        var result = (st, lb);
        return result;

        //return (st,lb);
    }

    public static int DoThis(int x, string y, out bool z) 
    {
        Console.WriteLine(y);
        z = (x > 10);
        return x * x;
    
    }
    
    public static void Add(int num) //copying
    {
        num++;
    }
    public static void Add(ref int num) //referencing
    {
        num++;
    }

    public static string OrderPizza(string pizzaToppings)
    {
        
        
        int pick;
        pick = Convert.ToInt32(Console.ReadLine());
        switch (pick) {
            case 1:
                pizzaToppings += "mushrooms";
                break;
            case 2:
                pizzaToppings += "anchovies";
                break;
            default:
                pizzaToppings = "Pinnaple on pizza is illegal";
            break;
        }
        return pizzaToppings;

        //if you have a method with a long parameter list is probably better if you refactor the code
    }

    public static int DoThis(int x, string y = "Happy")
    { 
    
        Console.WriteLine($"I am feeling {y}");
        //If i change the first element
        
        x = 3;
        return x * x;
    
    }


}
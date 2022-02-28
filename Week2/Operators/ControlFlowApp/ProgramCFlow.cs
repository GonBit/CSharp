using System;

namespace ControlFlowApp;

public class ProgramCFlow 
{

    public static void Main(string[] args)
    {

        int mark = 35;
        GetGrade(mark);
        var message = Priority(2);

        var nums = new List<int> { 10, 6 , 22 ,-7, 3};
        Console.WriteLine("Highest foreach : " + LoopTypes.HighestForEachLoop(nums));
        Console.WriteLine("Highest for loop : " + LoopTypes.HighestForLoop(nums));
        Console.WriteLine("Highest while loop : " + LoopTypes.HighestWhileLoop(nums));
        Console.WriteLine("Highest do-while loop : " + LoopTypes.HighestDoWhileLoop(nums));
    }


    public static string Priority(int level) {

        string priority = "Code ";
        switch (level)
        {
            case 3:
                priority += "Red";
                break;
            case 2:
            case 1:
                priority += "Green";
                break;
            case 0:
                priority += "Purple";
                break;


            default:
                priority = "Error";
                break;
        }

        return priority;

    }

    private static void GetGrade(int mark)
    {
        //var grade = mark >= 65 ? "Pass" : "Fail";
        //Console.WriteLine(grade);

        var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
}
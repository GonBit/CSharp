using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            return -1;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;

            switch (age)
            {
                case < 5:
                    ticketType = "Free";
                    break;
                case >= 5 and <= 12:
                    ticketType = "Child";
                    break;
                case >= 13 and <= 17:
                    ticketType = "Student";
                    break;
                case >= 18 and <= 59:
                    ticketType = "Standard";
                    break;
                case >= 60:
                    ticketType = "OAP";
                    break;
                default:
                    ticketType = "Invalid Age";
                    break;
            }


            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            return 0;
        }
    }
}

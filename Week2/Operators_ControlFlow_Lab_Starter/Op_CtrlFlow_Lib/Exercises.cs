using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0; //if num1 == num2 ? if false num1 mod num2
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {            
            if (nums.Count != 0)
            {
                double sum = 0.0;

                for (int i = 0; i < nums.Count; i++)
                {

                    sum += nums[i];//sum of the elements

                }
                return sum / nums.Count;//average
            }
            else                
                return 0;
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

            if (mark <= 39 && mark > 0)
            {
                grade = "Fail";

            }
            else if (mark <= 59 && mark >= 40)
            {

                grade = "Pass";
            }
            else if (mark <= 74 && mark >= 60)
            {

                grade = "Pass with Merit";
            }
            else if (mark >= 75 && mark <= 100)
            {

                grade = "Pass with Distinction";
            }
            else
                grade = "Invalid mark";

            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int maxAttendees = 0;
            switch (covidLevel)
            {
                case 4:
                    maxAttendees = 20;
                    break;

                case 3:
                    maxAttendees = 50;
                    break;

                case 2:
                    maxAttendees = 75;
                    break;

                case 1:
                    maxAttendees = 100;
                    break;

                case 0:
                    maxAttendees = 200;
                    break;

                default:
                    maxAttendees = 0;
                    break;
            }

            return maxAttendees;

            
        }
    }
}

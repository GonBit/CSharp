using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            var age = date.Year - birthDate.Year;

            if ( birthDate.Month > date.Month)//checks if he his birthday has passed
            {
                age--;
            }
            
            if (date.Year == birthDate.Year) 
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            else 
                return age;
            

        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            switch (suit)
            {
                case Suit.CLUBS:
                    return  "And the seventh rule is if this is your first night at fight club, you have to fight.";                   
                case Suit.DIAMONDS:
                    return  "Diamonds are a girls best friend";                    
                case Suit.HEARTS:
                    return "You've broken my heart";                    
                case Suit.SPADES:
                    return "Bucket and spade";
                default:
                 throw new ArgumentException("Please provide a good argument");                   
            
            }            
           
        }
    }
}

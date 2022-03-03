using System;
using System.Collections.Generic;
using System.Text;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {

            var stringB = new StringBuilder(input.Trim().ToUpper());
            for (int i = 0; i < num; i++)
            { 
            
                stringB.Append(i);//Append

            }
            return stringB.ToString();

        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            string returnString = String.Concat(number + " " + street + ", " + city + " " + postcode + ".");
          
            return returnString;
            //more efficient solution return $"You got {number} {street}, {city} {postcode}." 

        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            
            //string returnString = $"You got {score} out of {outOf}: {division:P}";
            //solution
            string returnString = $"You got {score} out of {outOf}: {(float)score/outOf:P1}";

            return returnString;
            //throw new NotImplementedException();
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {                        
            
            double output;         
            if (double.TryParse(numString, out output))
            {
                return output;
            }
            else
                return -999;            

        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            char ah = 'A';
            char bh = 'B';
            char ch = 'C';
            char dh = 'D';

            foreach (char a in input)
            {
                if (a == ah)
                { 
                    aCount++;
                }

            }
            foreach (char b in input)
            {
                if (b == bh)
                {
                    bCount++;
                }

            }
            foreach (char c in input)
            {
                if (c == ch)
                {
                    cCount++;
                }

            }
            foreach (char d in input)
            {
                if (d == dh)
                {
                    dCount++;
                }

            }
            //Convert to switch case


            return "A:"+aCount + " B:"+ bCount + " C:"+ cCount + " D:"+ dCount;


        }
    }
}

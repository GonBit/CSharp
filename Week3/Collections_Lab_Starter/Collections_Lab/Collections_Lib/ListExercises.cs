using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var multFiveL = new List<int>();
            for (int x = 1; x <= max; x++)
            {
                if (x % 5 == 0)
                { 
                    multFiveL.Add(x);
                }            
            }            
            return multFiveL;            
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var list = new List<string>();
            foreach (var item in sourceList)
            {
                if (item.StartsWith("A") || item.StartsWith("a"))
                { 
                    list.Add(item);
                }
            }
            return list;
        }
    }
}

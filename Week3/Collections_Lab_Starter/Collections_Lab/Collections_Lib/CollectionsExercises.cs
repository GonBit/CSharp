using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string returnS = "";

            if (num > queue.Count)
            {
                int count = queue.Count;
                for (int x = 0; x <= count -1/*gives the amount not the index*/; x++)
                {
                    returnS = returnS + queue.Peek();
                    queue.Dequeue();
                    returnS = returnS + ", ";
                }
                return returnS.Substring(0, returnS.Length - 2);
            }
            
            if (num == 0)
            {
                return returnS;
            }
            else
            {
                for (int x = 0; x < num; x++)
                {
                    returnS = returnS + queue.Peek(); 
                    queue.Dequeue();
                    returnS = returnS + ", ";
                }
                return returnS.Substring(0, returnS.Length - 2);
            }                       

        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int size = 0;
            int[] reversed;            
            var stack = new Stack<int>();

            foreach (var item in original)//Filling up the stack
            {
                stack.Push(item);
                size++;
            }
            reversed = new int[size];
            for (int i = 0; i < original.Length; i++)//
            {
                reversed[i] = stack.Pop();
            }
            return reversed;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            String returnS = "";
            var dictionary = new Dictionary<char, int>();
            var array = input.ToCharArray();

            foreach (char item in array)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else if (Char.IsDigit(item))
                { 
                    dictionary.Add(item, 1);
                }
            }
            foreach (var item in dictionary)
            {
                returnS += item;
            }

            return returnS;
        }
    }
}

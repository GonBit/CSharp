using System;

namespace StringCalculator;

public class Program
{
    public static void Main(string[] agrs)
    {
        
    
    }

    public static int Add(string numbers)
    {
        if(numbers == "" && numbers == null)//Checks if string is empty and returns zero
            return 0;

        //Step 5
        string negativeNums = "";
        if (numbers.Contains('-'))
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '-')
                {
                    negativeNums += numbers.Substring(i, numbers.IndexOf(',', i, i+4)) + " ";
                }
            }
            throw new ArgumentException($"Negatives not allowed {negativeNums}");
        }

        int sum = 0;
        if (numbers.Substring(0, 2) == "//") //Checks if input starts with //
        {
            var delimiter = numbers[2]; //stores delimiter in variable
            var newNumbers = numbers.Substring(4, numbers.Length - 4); //remove non-numbers
            var arrayDel = newNumbers.Split(delimiter); //splits string using delimiter

            for (int i = 0; i < arrayDel.Length; i++)
            {
                sum += Int32.Parse(arrayDel[i]);
            }
            return sum;
        }

        else 
        {
            var array = numbers.Split(new char[] { ',', '\n' });          

            for (int i = 0; i < array.Length; i++)
            {
                sum += Int32.Parse(array[i]);
            }
            return sum;
        }

    }
}
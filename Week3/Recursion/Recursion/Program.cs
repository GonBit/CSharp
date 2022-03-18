using System;

namespace Recursion;

public class Program
{
    public static void Main(string[] args)
    {
        int[] leftArray = { 8, 9, 10, 11, 12, 13, 14 };
        int[] rightArray = { 1, 2, 3, 4, 5, 6, 7 };
        

        int[] array = MergeArray(leftArray, rightArray);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }


        //MergeArray(leftArray, rightArray);

        int[] arr = new int[] { 5, 4, 3, 2, 1 };
        BubSort(arr);

        foreach (int i in arr)
        {
            //Console.WriteLine(i);
        } 

        
    }


    public static void BubSort(int[] array)
    {
        int temp = 0;        
        for (int i = 0; i < array.Length - 1; i++)
        {           
            for (int j = 0 ; j < array.Length -1 - i ; j++)
            {                
                if (array[j] > array[j+1])
                {                    
                    temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;                    
                }
            }
        }        
    }



    public static void BubSort2(int[] array)
    {
        int temp = 0;
        for (int i = 0; i <= array.Length - 2; i++)
        {
            for (int j = 0; j <= array.Length - 2; j++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i + 1];
                    array[i + 1] = array[j];
                    array[j] = temp;
                   // Console.WriteLine(temp);
                }
            }
        }
    }


    private static int[] MergeArray(int[] right, int[]left)
    {
        
        int[] combArray = left.Concat(right).ToArray();

        return left.Concat(right).ToArray();
    }//Using LINQ



    private static int SumRecursive(int v)
    {
        //base case prevents infinite recursion
        if (v == 1) return 1;

        int prev = SumRecursive(v - 1);
        int sum = v + prev;
        return sum;
    }

    private static int SumLoop(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}


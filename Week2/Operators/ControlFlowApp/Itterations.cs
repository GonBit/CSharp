using System;
using System.Collections.Generic;

namespace ControlFlowApp
{
    public static class LoopTypes
    {
        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = nums[0];
            foreach (var item in nums)                
            { 
                if (item > highest)
                {
                    highest = item;
                }
            }
            return highest;

        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }

            }
            return highest;
        }

        internal static int HighestWhileLoop(List<int> nums)
        {
            int highest = nums[0];
            int i = 0;
            while (i < nums.Count)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }

            return highest;
        }

        internal static int HighestDoWhileLoop(List<int> nums)
        {

            int highest = nums[0];
            int i = 0;

            do
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;

            } while (i < nums.Count);

            return highest;
        }
    }
}

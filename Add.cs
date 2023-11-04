//Given an array A and an integer target, find the indices of the two numbers in the array whose sum is equal to the given target.

//Note: The problem has exactly one solution. Do not use the same element twice.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for (int test = 0; test < t; test++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int target = int.Parse(Console.ReadLine);

            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int complement = target - nums[i];
                if (numIndices.ContainsKey(complement))
                {
                    Console.WriteLine(numIndices[complement] + " " + i);
                    break;
                }
                numIndices[nums[i]] = i;
            }
        }
    }
}

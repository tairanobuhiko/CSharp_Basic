using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string input;
        while ((input = Console.ReadLine()) != null)
        {
            List<int> nums = input.Split(" ").Select(int.Parse).ToList();
            int lastIndex = nums.Count - 1;
            for (int i = 1; i <= lastIndex; i++)
            {
                if (i != lastIndex)
                {
                    Console.Write($"{nums[i]} ");
                }
                else
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }
    }
}
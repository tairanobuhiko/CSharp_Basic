using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Console.WriteLine(nums[input[1] - 1]);
    }
}
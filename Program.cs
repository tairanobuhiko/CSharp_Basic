using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int N = input[0];
        int M = input[1];

        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        List<int> result = nums.Where(n => n == N).ToList();
        Console.WriteLine(result.Count);
    }
}
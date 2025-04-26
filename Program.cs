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
        int M = input[1] - 1;

        List<string> nums = Console.ReadLine().Split(" ").ToList();
        List<string> orderResult = nums.OrderBy(x => x).ToList();
        Console.WriteLine(orderResult[M]);
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int N = input[0];
        int K = input[1];

        List<int> nums = new List<int>();
        for (int i = 0; i < N; i++)
        {
            nums.Add(int.Parse(Console.ReadLine()));
        }

        int count = nums.Where(n => n == K).Count();
        Console.WriteLine(count);
    }
}
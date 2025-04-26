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
        int K = input[2] - 1;
        int L = input[3] - 1;

        List<List<int>> dimension2 = new();

        for (int i = 0; i < N; i++)
        {
            List<int> dimension1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            dimension2.Add(dimension1);
        }

        Console.WriteLine(dimension2[K][L]);
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        List<int> result = input.Distinct().OrderBy(x => x).ToList();
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }
}
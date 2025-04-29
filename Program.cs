using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> list = new List<int>();
        for (int i = 0; i < input[0]; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        list.Insert(input[1], input[2]);

        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
    }
}
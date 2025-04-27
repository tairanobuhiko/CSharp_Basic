using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        foreach (int num in input)
        {
            if (num != -1)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num);
                break;
            }
        }
    }
}
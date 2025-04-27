using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        foreach (int num in input)
        {
            Console.WriteLine(num % 2 == 0
                ? "even"
                : "odd");
        }
    }
}
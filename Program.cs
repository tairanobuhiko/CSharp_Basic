using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        List<int> result = new List<int>();
        foreach (int n in arr1)
        {
            foreach (int k in arr2)
            {
                result.Add(n * k);
            }
        }
        Console.WriteLine(result.Max());
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<(string a, int n)> list = new List<(string, int)>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            list.Add((input[0], int.Parse(input[1])));
        }

        List<(string, int)> result = list.OrderBy(item => item.n).ToList();
        foreach ((string a, int num) tuple in result)
        {
            Console.WriteLine(tuple.a);
        }
    }
}

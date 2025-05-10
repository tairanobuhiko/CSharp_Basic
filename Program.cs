using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, int> data = new Dictionary<string, int>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            string key = input[0];
            int value = int.Parse(input[1]);

            data[key] = data.ContainsKey(key)
                ? data[key] += value
                : data[key] = value;
        }

        foreach (var pair in data.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{pair.Key} {pair.Value}");
        }
    }
}

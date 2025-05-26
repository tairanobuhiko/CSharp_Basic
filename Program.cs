using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        var uniqueWords = input.Distinct();

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        foreach (string color in input)
        {
            if (wordsCount.ContainsKey(color))
            {
                wordsCount[color] += 1;
            }
            else
            {
                wordsCount[color] = 1;
            }
        }

        foreach (var pair in wordsCount)
        {
            Console.WriteLine($"{pair.Key} {pair.Value}");
        }
    }
}

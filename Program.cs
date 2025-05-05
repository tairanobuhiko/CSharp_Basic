using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        string[] input = Console.ReadLine().Select(x => x.ToString()).ToArray();

        List<string> result = new List<string>();
        for (int i = nums[0] - 1; i < nums[1]; i++)
        {
            result.Add(input[i]);
        }
        Console.WriteLine(string.Join("", result));
    }
}
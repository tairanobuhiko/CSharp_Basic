using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int a = nums[0] - 1;
        int b = nums[1] - 1;
        List<string> refferenceNums = new List<string>();
        for (int i = a; i <= b; i++)
        {
            refferenceNums.Add(i.ToString());
        }

        string[] input = Console.ReadLine().Select(s => s.ToString()).ToArray();
        List<string> result = new List<string>();
        try
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (refferenceNums.Contains(i.ToString()))
                {
                    result.Add(input[i].ToUpper());
                }
                else
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

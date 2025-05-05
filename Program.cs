using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string targetStr = Console.ReadLine();
        string[] refferenceList = Console.ReadLine().Select(s => s.ToString()).ToArray();
        int count = 0;
        foreach (string s in refferenceList)
        {
            count += s == targetStr
                ? 1
                : 0;
        }
        Console.WriteLine(count);
    }
}
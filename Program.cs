using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        List<string> t = Console.ReadLine().Select(x => x.ToString()).ToList();
        int sLength = s.Length;
        int tLength = t.Count;
        int result = 0;
        for (int i = 0; i <= tLength - sLength; i++)
        {
            List<string> str = new List<string>();
            for (int k = i; k < i + sLength; k++)
            {
                str.Add(t[k]);
            }
            string compareStr = String.Join("", str);
            if (compareStr == s)
            {
                result += 1;
            }
        }
        Console.WriteLine(result);
    }
}
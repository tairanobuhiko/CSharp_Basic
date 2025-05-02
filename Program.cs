using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < N; i++)
        {
            int num = int.Parse(Console.ReadLine());
            result += num >= 5
                ? num
                : 0;
        }
        Console.WriteLine(result);
    }
}
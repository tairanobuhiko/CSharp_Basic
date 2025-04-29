using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> telNumber = new List<string>();
        int N = 3;
        for (int i = 0; i < N; i++)
        {
            string num = Console.ReadLine();
            telNumber.Add(num);
        }
        Console.WriteLine($"{telNumber[0]}-{telNumber[1]}-{telNumber[2]}");
    }
}
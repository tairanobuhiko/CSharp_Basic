using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        bool succses = int.TryParse(Console.ReadLine(), out int N);

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            TimeSpan targetTime = TimeSpan.Parse(input[0]);
            int hour = int.Parse(input[1]);
            int minute = int.Parse(input[2]);

            TimeSpan addTime = new TimeSpan(hour, minute, 0);
            DateTime baseTime = new DateTime(2025, 4, 29, targetTime.Hours, targetTime.Minutes, 0);
            DateTime resultTime = baseTime + addTime;
            Console.WriteLine(resultTime.ToString("HH:mm"));
        }
    }
}
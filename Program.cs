using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int N = input[0];
        int K = input[1];
        int P = input[2];

        List<int> students = new List<int> { P };
        for (int i = 0; i < N; i++)
        {
            students.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < K; i++)
        {
            string[] query = Console.ReadLine().Split(" ");
            switch (query[0])
            {
                case "join":
                    Join(students, int.Parse(query[1]));
                    break;

                case "sorting":
                    Console.WriteLine(Sorting(students, P));
                    break;
            }
        }

    }

    private static void Join(List<int> students, int height)
    {
        students.Add(height);
    }

    private static int Sorting(List<int> students, int P)
    {
        int count = 0;
        foreach (var h in students)
        {
            if (h < P) count++;
        }
        return count + 1;
    }
}
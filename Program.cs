using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Tuple<string, string>> users = new List<Tuple<string, string>>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            Tuple<string, string> tuple = Tuple.Create(input[0], input[1]);
            users.Add(tuple);
        }

        int M = int.Parse(Console.ReadLine());
        Dictionary<string, string> lists = new Dictionary<string, string>();
        for (int i = 0; i < M; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            lists.Add(input[0], input[1]);
        }

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Item1} {lists[user.Item2]}");
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        var members = new SortedSet<string>();

        for (int i = 0; i < N; i++)
        {
            members.Add(Console.ReadLine());
        }

        for (int i = 0; i < K; i++)
        {
            string[] prompt = Console.ReadLine().Split();
            if (prompt[0] == "handshake")
            {
                foreach (string name in members)
                {
                    Console.WriteLine(name);
                }
            }
            else if (prompt[0] == "join")
            {
                members.Add(prompt[1]);
            }
            else if (prompt[0] == "leave")
            {
                members.Remove(prompt[1]);
            }
        }
    }
}

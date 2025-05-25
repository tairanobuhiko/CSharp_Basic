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
        List<Idol> members = new List<Idol>();
        for (int i = 0; i < N; i++)
        {
            string member = Console.ReadLine();
            members.Add(new Idol(member));
        }

        for (int i = 0; i < K; i++)
        {
            string[] prompt = Console.ReadLine().Split(" ");
            switch (prompt[0])
            {
                case "handshake":
                    Idol.HandShake(members);
                    break;

                case "join":
                    Idol.Join(members, prompt[1]);
                    break;

                case "leave":
                    Idol.Leave(members, prompt[1]);
                    break;

                default:
                    break;
            }
        }
    }

    public class Idol
    {
        public string Name { get; set; }
        public Idol(string name)
        {
            this.Name = name;
        }

        public static void Join(List<Idol> members, string name)
        {
            members.Add(new Idol(name));
        }

        public static void Leave(List<Idol> members, string name)
        {
            int index = members.FindIndex(i => i.Name == name);
            members.RemoveAt(index);
        }

        public static void HandShake(List<Idol> members)
        {
            if (members.Count == 0) return;
            List<Idol> sortMember = members
                .OrderBy(m => m.Name)
                .ToList();
            foreach (Idol member in sortMember)
            {
                Console.WriteLine(member.Name);
            }
        }
    }
}
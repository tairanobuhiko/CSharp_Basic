using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int N = input[0];
        int K = input[1];

        List<int> members = new List<int>();
        for (int i = 1; i <= N; i++)
        {
            members.Add(i);
        }
        for (int i = 0; i < K; i++)
        {
            string[] prompt = Console.ReadLine().Split(" ");
            switch (prompt[0])
            {
                case "swap":
                    Swap(int.Parse(prompt[1]) - 1, int.Parse(prompt[2]) - 1, members);
                    break;

                case "reverse":
                    Reverse(members);
                    break;

                case "resize":
                    Resize(int.Parse(prompt[1]), members);
                    break;
            }
        }
        foreach (int member in members)
        {
            Console.WriteLine(member);
        }
    }

    ///<summary>
    /// 先頭から A 番目の人と、先頭から B 番目の人の位置を入れ替える。
    ///</summary>
    /// <param name="A">入れ替え先</param>
    /// <param name="B">入れ替え元</param>
    /// <returns>戻り値なし</returns>
    private static void Swap(int A, int B, List<int> members)
    {
        (members[A], members[B]) = (members[B], members[A]);
    }

    ///
    /// <summary>
    /// reverse
    /// 列の前後を入れ替える。
    /// </summary>
    private static void Reverse(List<int> members)
    {
        members.Reverse();
    }

    /// <summary>
    /// resize C
    /// 先頭から C 人を列に残し、それ以外の人を全員列から離れさせる。ただし、列が既に C 人以下の場合、何も行わない。
    /// </summary>
    private static void Resize(int c, List<int> members)
    {
        if (members.Count > c)
        {
            members.RemoveRange(c, members.Count - c);
        }
    }
}
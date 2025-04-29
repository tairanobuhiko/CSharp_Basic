using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        List<string> list = new List<string>();
        for (int i = 0; i < N; i++)
        {
            SearchHistory(list, Console.ReadLine());
        }
        foreach (string word in list)
        {
            Console.WriteLine(word);
        }
    }

    private static List<string> SearchHistory(List<string> list, string word)
    {
        int index = list.IndexOf(word);
        if (index >= 0)
        {
            list.RemoveAt(index);
        }
        list.Insert(0, word);
        return list;
    }
}
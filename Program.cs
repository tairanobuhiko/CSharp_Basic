using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<List<string>> board = new List<List<string>>();
        int N = input[0];
        for (int i = 0; i < N; i++)
        {
            board.Add(Console.ReadLine().Select(s => s.ToString()).ToList());
        }

        int row = input[2] - 1;
        int col = input[3] - 1;
        string result = board[row][col] == "#"
            ? "Yes"
            : "No";
        Console.WriteLine(result);
    }
}
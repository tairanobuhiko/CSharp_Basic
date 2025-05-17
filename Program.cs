using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
class Program
{
    static void Main()
    {
        int N = 5;
        List<Board> boards = new List<Board>();
        for (int i = 0; i < N; i++)
        {
            List<string> input = Console.ReadLine().Select(x => x.ToString()).ToList();
            boards.Add(new Board(input));
        }

        int O = JudgeWinner(boards, "O");
        int X = JudgeWinner(boards, "X");
        if ((O == 5 && X == 5) || (O < 5 && X < 5))
        {
            Console.WriteLine("D");
        }
        else if (O == 5 && X < 5)
        {
            Console.WriteLine("O");
        }
        else
        {
            Console.WriteLine("X");
        }
    }

    class Board
    {
        public List<string> cell { get; set; } = new List<string>();
        public Board(List<string> input)
        {
            this.cell = input;
        }
    }

    static int JudgeWinner(List<Board> boards, string target)
    {
        // 横方向の探索
        int result = 0;
        foreach (Board board in boards)
        {
            result = board.cell.Where(x => x.Contains(target)).ToList().Count;
            if (result == 5) break;
        }
        if (result == 5) return result;

        // 縦方向の探索
        for (int i = 0; i < 5; i++)
        {
            result = 0;
            for (int k = 0; k < 5; k++)
            {
                result += boards[k].cell[i] == target
                    ? 1
                    : 0;
            }
            if (result == 5) break;
        }
        if (result == 5) return result;

        // 斜め方向の探索(1)
        result = 0;
        for (int i = 0; i < 5; i++)
        {
            result += boards[i].cell[i] == target
                ? 1
                : 0;
        }
        if (result == 5) return result;

        // 斜め方向の探索(2)
        result = 0;
        for (int i = 0; i < 5; i++)
        {
            result += boards[4 - i].cell[i] == target
                ? 1
                : 0;
        }
        return result;
    }
}
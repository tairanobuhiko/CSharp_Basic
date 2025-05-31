using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<List<string>> boards = new List<List<string>>();
        List<int> prompt = Console.ReadLine()
            .Split(" ")
            .Select(n => int.Parse(n))
            .ToList();

        int H = prompt[0];

        for (int i = 0; i < H; i++)
        {
            List<string> board = new List<string>();
            board = Console.ReadLine()
                .Select(x => x.ToString())
                .ToList();

            boards.Add(board);
        }

        int[] changeIndex = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

        string checkChar = boards[changeIndex[0]][changeIndex[1]];
        boards[changeIndex[0]][changeIndex[1]] = ChangeCell(checkChar);

        foreach (var board in boards)
        {
            Console.WriteLine(String.Join("", board));
        }
    }

    static string ChangeCell(string cell)
    {
        switch (cell)
        {
            case "#":
                cell = ".";
                break;

            case ".":
                cell = "#";
                break;

            default:
                break;

        }
        return cell;
    }
}

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
        int W = prompt[1];

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

        List<List<int>> targetCells = ChangeCrossCell(H - 1, W - 1, changeIndex[0], changeIndex[1]);
        foreach (var cells in targetCells)
        {
            checkChar = string.Empty;
            checkChar = boards[cells[0]][cells[1]];
            boards[cells[0]][cells[1]] = ChangeCell(checkChar);
        }

        foreach (var board in boards)
        {
            Console.WriteLine(String.Join("", board));
        }
    }

    static string ChangeCell(string cell)
    {
        return cell = cell switch
        {
            "#" => ".",
            "." => "#",
            _ => String.Empty
        };
    }

    static List<List<int>> ChangeCrossCell(int h, int w, int y, int x)
    {
        List<List<int>> list = new List<List<int>>();
        // top
        if (y > 0 && y <= h) list.Add(new List<int>() { y - 1, x });

        // down
        if (y < h) list.Add(new List<int>() { y + 1, x });

        // left
        if (x > 0 && x <= w) list.Add(new List<int>() { y, x - 1 });

        // right
        if (x < w) list.Add(new List<int>() { y, x + 1 });

        return list;
    }
}

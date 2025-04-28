using System;

class Program
{
    static void Main()
    {
        bool succes = int.TryParse(Console.ReadLine(), out int month);


        string season = month switch
        {
            (>= 3 and <= 5) => "春",
            (>= 6 and <= 8) => "夏",
            (>= 9 and <= 11) => "秋",
            (12 or 1 or 2) => "冬",
            _ => "不正な月"
        };
        Console.WriteLine($"{month}月は{season}です");
    }
}
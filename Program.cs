using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string winnerNumber = Console.ReadLine();
        // 当選番号定義
        List<int> splitWinnerNumbers = winnerNumber.Select(x => int.Parse(x.ToString())).ToList();
        WinnerNumber.ONE = int.Parse(winnerNumber);
        WinnerNumber.ADJACENT.Add(WinnerNumber.ONE - 1);
        WinnerNumber.ADJACENT.Add(WinnerNumber.ONE + 1);
        WinnerNumber.SECOND = WinnerNumber.GenerateFilterNumber(splitWinnerNumbers, 4);
        WinnerNumber.THIRD = WinnerNumber.GenerateFilterNumber(splitWinnerNumbers, 3);

        List<string> results = new List<string>();
        bool success = int.TryParse(Console.ReadLine(), out int N);
        for (int i = 0; i < N; i++)
        {
            int buyNumber = int.Parse(Console.ReadLine());
            results.Add(WinnerNumber.JudgeWinner(buyNumber));
        }
        foreach (string result in results) Console.WriteLine(result);
    }

    class WinnerNumber
    {
        public static int ONE { get; set; }

        public static List<int> ADJACENT { get; set; } = new List<int>();
        public static int SECOND { get; set; }
        public static int THIRD { get; set; }
        public static string JudgeWinner(int number)
        {
            string result = string.Empty;
            if (ONE == number) result = "first";
            else if (ADJACENT[0] == number || ADJACENT[1] == number) result = "adjacent";
            else if (SECOND == WinnerNumber.GenerateFilterNumber(number, 4)) result = "second";
            else if (THIRD == WinnerNumber.GenerateFilterNumber(number, 3)) result = "third";
            else result = "blank";

            return result;
        }

        public static int GenerateFilterNumber(List<int> numbers, int roopCount)
        {
            int n = numbers.Count;
            List<int> number = new List<int>();
            for (int i = n - roopCount; i < n; i++)
            {
                number.Add(numbers[i]);
            }
            return int.Parse(String.Join("", number));
        }

        public static int GenerateFilterNumber(int num, int roopCount)
        {
            List<int> numbers = new List<int>();
            numbers = num.ToString().Select(n => int.Parse(n.ToString())).ToList();

            int numsCount = numbers.Count;
            List<int> number = new List<int>();
            for (int i = numsCount - roopCount; i < numsCount; i++)
            {
                number.Add(numbers[i]);
            }
            return int.Parse(String.Join("", number));
        }
    }
}

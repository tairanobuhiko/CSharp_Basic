using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            string result = (i % 3, i % 5) switch
            {
                (0, 0) => "Fizz Buzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                _ => i.ToString()
            };
            Console.WriteLine(result);
        }
    }
}
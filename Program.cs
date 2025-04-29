using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            switch (i)
            {
                case int _ when i % 15 == 0:
                    Console.WriteLine("Fizz Buzz");
                    break;

                case int _ when i % 3 == 0:
                    Console.WriteLine("Fizz");
                    break;

                case int _ when i % 5 == 0:
                    Console.WriteLine("Buzz");
                    break;

                default:
                    Console.WriteLine(i);
                    break;
            }
        }
    }
}
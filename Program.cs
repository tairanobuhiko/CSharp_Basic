using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> alphabet = new List<string>() {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        string X = Console.ReadLine();
        string Y = Console.ReadLine();
        string C = Console.ReadLine();

        int indexX = alphabet.IndexOf(X);
        int indexY = alphabet.IndexOf(Y);
        int indexC = alphabet.IndexOf(C);

        if (indexX <= indexC && indexY >= indexC)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
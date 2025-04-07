using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    String input = Console.ReadLine();
    List<String> strs = input.Split(" ").ToList();
    int count = strs.Count;
    for (int i = 0; i < count; i++)
    {
      Console.WriteLine(strs[i]);
    }
  }
}
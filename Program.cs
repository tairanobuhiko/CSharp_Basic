using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    SamplePrint((38, "Taira"));
  }
  static void SamplePrint((int age, String name) sample)
  {
    Console.WriteLine($"私の名前は{sample.name}です。年齢は{sample.age}歳です");
  }
}
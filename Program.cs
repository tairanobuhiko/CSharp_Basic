using System;
using System.Linq;
using System.Collections.Generic;
using MyClass;

class Program
{
  static void Main()
  {
    Sample sample = new Sample(36, "Sayaka");
    sample.SamplePrint((38, "Taira"));
    sample.SamplePrint();
  }
}
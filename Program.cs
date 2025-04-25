using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Diagnostics;
using System.Collections;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        int N = int.Parse(input[0]);
        int Q = int.Parse(input[1]);
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        // クエリ処理（Q回）
        for (int i = 0; i < Q; i++)
        {
            int[] query = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            switch (query[0])
            {
                case 0:
                    PushBack(query[1], nums);
                    break;

                case 1:
                    PopBack(nums);
                    break;

                case 2:
                    Print(nums);
                    break;

                default:
                    break;
            }
        }
    }


    private static void PushBack(int x, List<int> nums)
    {
        nums.Add(x);
    }

    private static void PopBack(List<int> nums)
    {
        int index = nums.Count - 1;
        nums.RemoveAt(index);
    }

    private static void Print(List<int> nums)
    {
        int lastIndex = nums.Count - 1;
        for (int i = 0; i <= lastIndex; i++)
        {
            if (i != lastIndex)
            {
                Console.Write($"{nums[i]} ");
            }
            else
            {
                Console.WriteLine(nums[i]);
            }
        }
    }

}
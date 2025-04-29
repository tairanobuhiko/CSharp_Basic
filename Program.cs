using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        List<int> nums = new List<int>();
        for (int i = 0; i < input[0]; i++)
        {
            nums.Add(int.Parse(Console.ReadLine()));
        }

        // query
        for (int i = 0; i < input[1]; i++)
        {
            var query = Console.ReadLine();
            List<int> result = query switch
            {
                "pop" => Pop(nums),
                "show" => Show(nums),
                _ => nums
            };
        }
    }

    /// <summary>
    /// A の先頭の要素を削除する。既に A に要素が存在しない場合何もしない。
    /// </summary>
    private static List<int> Pop(List<int> nums)
    {
        if (nums.Count > 0)
        {
            nums.RemoveAt(0);
        }
        return nums;
    }

    /// <summary>
    /// A の要素を先頭から順に改行区切りで出力する。A に要素が存在しない場合何も出力しない。
    /// </summary>
    private static List<int> Show(List<int> nums)
    {
        if (nums.Count > 0)
        {
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
        return nums;
    }
}
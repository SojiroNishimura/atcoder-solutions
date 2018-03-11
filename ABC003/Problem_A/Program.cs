using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            //var a = new string[] { "abcd", "dbca", "abab"};
            //var b = new string[] { "cbad", "dacb", "abcdef" };
            //var ans = new List<string>();

            //for (var i = 0; i < a.Length; i++)
            //{
            //    if (a[i].Length != b[i].Length)
            //    {
            //        ans.Add("No");
            //    }
            //    else
            //    {
            //        var evenA = new List<char>();
            //        var evenB = new List<char>();
            //        var oddA = new List<char>();
            //        var oddB = new List<char>();

            //        for (var j = 0; j < a[i].Length; j++)
            //        {
            //            if (j % 2 == 1)
            //            {
            //                evenA.Add(a[i][j]);
            //                evenB.Add(b[i][j]);
            //            }
            //            else
            //            {
            //                oddA.Add(a[i][j]);
            //                oddB.Add(b[i][j]);
            //            }
            //        }
            //        evenA.Sort();
            //        evenB.Sort();
            //        oddA.Sort();
            //        oddB.Sort();
            //        Console.WriteLine($"EvenA : {string.Join(" ", evenA)}");
            //        Console.WriteLine($"EvenB : {string.Join(" ", evenB)}");
            //        Console.WriteLine($"OddA : {string.Join(" ", oddA)}");
            //        Console.WriteLine($"OddB : {string.Join(" ", oddB)}");
            //        Console.WriteLine($"{evenA.SequenceEqual(evenB)}");
            //        Console.WriteLine($"{oddA.SequenceEqual(oddB)}");
            //        if (evenA.SequenceEqual(evenB) && oddA.SequenceEqual(oddB))
            //        {
            //            ans.Add("Yes");
            //        }
            //        else
            //        {
            //            ans.Add("No");
            //        }
            //    }
            //}
            //Console.WriteLine($"{string.Join(",", ans)}");

            //var done = int.Parse(Console.ReadLine());
            //var sum = 0;
            //for (var i = 1; i <= done; i++)
            //{
            //    sum += 10000 * i;
            //}
            //var salary = Math.Round(sum / (double)done);
            //Console.WriteLine($"{salary}");
        }
    }
}

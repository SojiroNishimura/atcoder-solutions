using System;
using System.Collections.Generic;

namespace Problem_C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var n = int.Parse(Console.ReadLine());
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num)) dict[num] += 1;
                else dict.Add(num, 1);
            }

            var count = 0;
            foreach (var e in dict)
            {
                if (e.Value < e.Key)
                {
                    count += e.Value;
                }
                else if (e.Value > e.Key)
                {
                    count += e.Value - e.Key;
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}

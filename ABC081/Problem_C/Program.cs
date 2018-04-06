using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0], k = inputs[1];
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num)) dict[num] += 1;
                else dict.Add(num, 1);
            }

            if (dict.Keys.Count > k)
            {
                var delCount = 0;
                var sorted = dict.OrderBy(num => num.Value).ToArray();
                for (var i = 0; i < dict.Keys.Count - k; i++)
                {
                    delCount += sorted[i].Value;
                }
                Console.WriteLine($"{delCount}");
            }
            else Console.WriteLine("0");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC083
{
    public class Problem_B
    {
        public Problem_B()
        {
            var reader = new System.IO.StreamReader("Inputs_B.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_B");
            var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[1], b = input[2];
            var candidates = new List<int>();
            for (var i = 1; i <= input[0]; i++)
            {
                var intStr = i.ToString();
                var sum = 0;
                foreach (var c in intStr)
                {
                    var digit = (int)Char.GetNumericValue(c);
                    sum += digit;
                }
                if (sum >= a && sum <= b) candidates.Add(i);
            }
            Console.WriteLine($"{candidates.Sum()}");
        }

        public void Solve2()
        {
            Console.WriteLine("Problem_B");
            var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], a = input[1], b = input[2];
            var ans = 0;
            for (var i = 1; i <= n; i++)
            {
                var sum = 0;
                var num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum >= a && sum <= b) ans += i;
            }
            Console.WriteLine($"{ans}");
        }
    }
}
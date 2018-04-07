using System;
using System.Collections.Generic;

namespace ABC093
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
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = inputs[0], b = inputs[1], k = inputs[2];

            var set = new HashSet<int>();
            for (var i = a; i < a + k; i++)
            {
                if (a <= i && i <= b) set.Add(i);
            }
            for (var i = b - k + 1; i <= b; i++)
            {
                if (a <= i && i <= b) set.Add(i);
            }
            foreach (var num in set) Console.WriteLine($"{num}");
        }
    }
}

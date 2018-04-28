using System;
using System.Linq;

namespace ABC067
{
    public class Problem_C
    {
        public Problem_C()
        {
            var reader = new System.IO.StreamReader("Inputs_C.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_C");
            var N = int.Parse(Console.ReadLine());
            var deck = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long total = deck.Sum();
            long snuke = 0;
            long minDiff = long.MaxValue;
            for (var i = 0; i < N - 1; i++)
            {
                snuke += deck[i];
                minDiff = Math.Min(minDiff, Math.Abs(snuke - (total - snuke)));
            }
            Console.WriteLine($"{minDiff}");
        }
    }
}

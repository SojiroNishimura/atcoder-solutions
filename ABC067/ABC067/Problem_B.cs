using System;
using System.Linq;

namespace ABC067
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
            int N = inputs[0], K = inputs[1];
            var lengths = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var ans = lengths.OrderBy(l => l).Reverse().Take(K).ToArray().Sum();
            Console.WriteLine($"{ans}");
        }
    }
}
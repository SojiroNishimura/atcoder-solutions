using System;
using System.Linq;

namespace ABC096
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
            var K = int.Parse(Console.ReadLine());
            int A = inputs[0], B = inputs[1], C = inputs[2];
            var max = Math.Max(A, Math.Max(B, C));
            var n = max;
            for (var i = 0; i < K; i++) n *= 2;
            Console.WriteLine($"{inputs.Sum() - max + n}");
        }
    }
}

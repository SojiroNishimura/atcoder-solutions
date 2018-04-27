using System;

namespace ABC074
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
            var N = int.Parse(Console.ReadLine());
            var K = int.Parse(Console.ReadLine());
            var x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var total = 0;
            for (var i = 0; i < N; i++)
            {
                total += Math.Min(2 * x[i], 2 * (K - x[i]));
            }
            Console.WriteLine($"{total}");
        }
    }
}

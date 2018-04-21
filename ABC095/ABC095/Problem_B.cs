using System;
using System.Linq;

namespace ABC095
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
            var N = inputs[0];
            var X = inputs[1];
            var M = new int[N];
            var total = 0;
            for (var i = 0; i < N; i++)
            {
                M[i] = int.Parse(Console.ReadLine());
                X -= M[i];
                total += 1;
            }
            var min = M.Min();
            while (X >= min)
            {
                X -= min;
                total += 1;
            }
            Console.WriteLine($"{total}");
        }
    }
}

using System;

namespace ABC078
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
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0], m = inputs[1];
            var p = Math.Pow(1 / 2d, m);
            var t = 100 * (n - m) + 1900 * m;
            Console.WriteLine($"{t * (1 / p)}");
        }
    }
}

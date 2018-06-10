using System;
using System.Linq;

namespace ABC099
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
            int a = inputs[0], b = inputs[1];

            var diff = b - a;
            var ans = Enumerable.Range(1, diff).Sum() - b;
            Console.WriteLine(ans);
        }
    }
}

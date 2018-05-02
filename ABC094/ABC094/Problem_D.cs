using System;
using System.Linq;

namespace ABC094
{
    public class Problem_D
    {
        public Problem_D()
        {
            var reader = new System.IO.StreamReader("Inputs_D.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_D");
            var N = int.Parse(Console.ReadLine());
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // See Pascal's triangle
            var max = nums.Max();
            var half = Math.Ceiling(max / 2d);
            var aj = 0;
            foreach (var num in nums)
            {
                aj = Math.Abs(half - num) < Math.Abs(half - aj) ? num : aj;
            }
            Console.WriteLine($"{max} {aj}");
        }
    }
}

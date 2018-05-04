using System;

namespace ABC064
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
            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var max = 0;
            var min = int.MaxValue;
            for (var i = 0; i < N - 1; i++)
            {
                max = Math.Max(max, a[i]);
                min = Math.Min(min, a[i]);
            }
            Console.WriteLine($"{max - min}");
        }
    }
}

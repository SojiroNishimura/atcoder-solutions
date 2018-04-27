using System;

namespace ABC074
{
    public class Problem_A
    {
        public Problem_A()
        {
            var reader = new System.IO.StreamReader("Inputs_A.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_A");
            var N = int.Parse(Console.ReadLine());
            var A = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(N * N) - A}");
        }
    }
}

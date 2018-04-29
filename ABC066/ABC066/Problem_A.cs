using System;

namespace ABC066
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
            var prices = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int A = prices[0], B = prices[1], C = prices[2];
            var min = Math.Min(A + B, Math.Min(A + C, B + C));
            Console.WriteLine($"{min}");
        }
    }
}

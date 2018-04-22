using System;

namespace ABC070
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
            int A = inputs[0], B = inputs[1], C = inputs[2], D = inputs[3];
            var start = Math.Max(A, C);
            var end = Math.Min(B, D);
            Console.WriteLine($"{Math.Max(0, end - start)}");
        }
    }
}

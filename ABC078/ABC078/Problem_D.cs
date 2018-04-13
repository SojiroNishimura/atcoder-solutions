using System;

namespace ABC078
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
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var deck = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0], z = inputs[1], w = inputs[2];
            var score = n >= 2 ? Math.Max(Math.Abs(deck[n - 1] - w), Math.Abs(deck[n - 2] - deck[n - 1])) : Math.Abs(deck[0] - w);
            Console.WriteLine($"{score}");
        }
    }
}

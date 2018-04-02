using System;
namespace ABC080
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
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0], a = inputs[1], b = inputs[2];
            Console.WriteLine($"{(n * a < b ? n * a : b)}");
        }
    }
}
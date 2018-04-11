using System;

namespace ABC076
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
            var r = int.Parse(Console.ReadLine());
            var g = int.Parse(Console.ReadLine());
            // (r + x) / 2 = g;
            Console.WriteLine($"{2 * g - r}");
        }
    }
}
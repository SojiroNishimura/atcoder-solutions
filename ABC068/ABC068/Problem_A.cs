using System;

namespace ABC068
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
            var n = Console.ReadLine();
            Console.WriteLine($"ABC{n}");
        }
    }
}
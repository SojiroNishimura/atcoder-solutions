using System;

namespace ABC095
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
            var s = Console.ReadLine();
            var p = 700;
            foreach (var c in s) if (c == 'o') p += 100;
            Console.WriteLine($"{p}");
        }
    }
}
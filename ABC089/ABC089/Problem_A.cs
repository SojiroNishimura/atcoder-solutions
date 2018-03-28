using System;

namespace ABC089
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
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n / 3}");
        }
    }
}

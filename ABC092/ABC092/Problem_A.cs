using System;

namespace ABC092
{
    public class Problem_A
    {
        public Problem_A()
        {
            var reader = new System.IO.StreamReader("Inputs_A.txt");
            Console.SetIn(reader);
            Console.WriteLine("Problem_A");
        }

        public void Solve()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Min(a, b) + Math.Min(c, d)}");
        }
    }
}

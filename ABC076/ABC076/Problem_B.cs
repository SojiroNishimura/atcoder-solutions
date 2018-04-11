using System;

namespace ABC076
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
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var min = 1;
            for (var i = 0; i < n; i++)
                min = Math.Min(min * 2, min + k);
            Console.WriteLine($"{min}");
        }
    }
}

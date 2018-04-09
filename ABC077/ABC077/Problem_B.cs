using System;

namespace ABC077
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
            var max = 0;
            for (var i = 1; i * i <= n; i++) max = i * i;
            Console.WriteLine($"{max}");
        }
    }
}

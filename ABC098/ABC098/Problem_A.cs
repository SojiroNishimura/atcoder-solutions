using System;

namespace ABC098
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
            var A = inputs[0];
            var B = inputs[1];
            var plus = A + B;
            var minus = A - B;
            var multi = A * B;
            Console.WriteLine($"{Math.Max(plus, Math.Max(minus, multi))}");
        }
    }
}

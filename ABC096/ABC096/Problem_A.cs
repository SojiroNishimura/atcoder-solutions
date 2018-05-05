using System;

namespace ABC096
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
            int m = inputs[0], d = inputs[1];
            var ans = d >= m ? m : m - 1;
            Console.WriteLine($"{ans}");
        }
    }
}

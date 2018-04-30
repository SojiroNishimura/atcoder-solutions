using System;

namespace ABC065
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
            int X = inputs[0], A = inputs[1], B = inputs[2];
            if (B <= A) Console.WriteLine("delicious");
            else if (B - A <= X) Console.WriteLine("safe");
            else Console.WriteLine("dangerous");
        }
    }
}
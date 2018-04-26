using System;

namespace ABC067
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
            int A = inputs[0], B = inputs[1];
            if (A % 3 == 0 || B % 3 == 0 || (A + B) % 3 == 0) Console.WriteLine("Possible");
            else Console.WriteLine("Impossible");
        }
    }
}
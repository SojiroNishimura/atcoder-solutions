using System;

namespace ABC086
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
            var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = line[0], b = line[1];
            if ((a * b) % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");
        }
    }
}
using System;

namespace ABC094
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
            int a = inputs[0], b = inputs[1], x = inputs[2];

            if (a <= x && x <= a + b) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}

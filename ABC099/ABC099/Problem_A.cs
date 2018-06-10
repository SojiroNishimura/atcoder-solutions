using System;

namespace ABC099
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
            var N = int.Parse(Console.ReadLine());
            if (N < 1000) Console.WriteLine("ABC");
            else Console.WriteLine("ABD");
        }
    }
}

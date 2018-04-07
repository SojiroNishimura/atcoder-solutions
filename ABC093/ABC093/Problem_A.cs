using System;

namespace ABC093
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
            var s = Console.ReadLine();
            if (s[0] != s[1] && s[0] != s[2] && s[1] != s[2]) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
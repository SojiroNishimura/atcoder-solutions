using System;

namespace ABC077
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
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            if (line1[0] == line2[2] && line1[1] == line2[1] && line1[2] == line2[0]) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}

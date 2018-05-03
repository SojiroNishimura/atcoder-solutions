using System;

namespace ABC064
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
            //var n = s.;
            if (int.Parse(s.Replace(" ", "")) % 4 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
    }
}
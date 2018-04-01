using System;

namespace ABC089
{
    public class Problem_B
    {
        public Problem_B()
        {
            var reader = new System.IO.StreamReader("Inputs_B.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_B");
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            var ans = s.Contains("Y") ? "Four" : "Three";
            Console.WriteLine(ans);
        }
    }
}
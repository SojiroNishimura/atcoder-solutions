using System;

namespace ABC088
{
    public class Problem_A
    {
        public Problem_A()
        {
            var reader = new System.IO.StreamReader("Inputs_A.txt");
            Console.SetIn(reader);
            Console.WriteLine("Problem_A");
        }

        public void Solve()
        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var ans = (n % 500) <= a ? "Yes" : "No";
            Console.WriteLine(ans);
        }
    }
}

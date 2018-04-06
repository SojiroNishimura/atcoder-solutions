using System;
using System.Linq;

namespace ABC080
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
            var n = Console.ReadLine();
            var sum = n.Select(c => (int) Char.GetNumericValue(c)).Sum();
            if (int.Parse(n) % sum == 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

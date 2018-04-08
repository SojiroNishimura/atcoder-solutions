using System;
using System.Linq;

namespace ABC078
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
            var inputs = Console.ReadLine().Split().Select(s => s[0]).ToArray();
            var ans = inputs[0] == inputs[1] ? "=" : inputs[0] < inputs[1] ? "<" : ">";
            Console.WriteLine(ans);
        }
    }
}

using System;
using System.Linq;

namespace ABC098
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
            var len = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();

            var ans = 0;
            for (var i = 1; i < s.Length - 1; i++)
            {
                var a = s.Take(i).ToArray();
                var b = s.Skip(i).ToArray();
                ans = Math.Max(ans, a.Intersect(b).Count());
            }
            Console.WriteLine(ans);
        }
    }
}

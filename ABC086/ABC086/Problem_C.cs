using System;
using System.Collections.Generic;

namespace ABC086
{
    public class Problem_C
    {
        public Problem_C()
        {
            var reader = new System.IO.StreamReader("Inputs_C.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_C");
            var n = int.Parse(Console.ReadLine());
            var routes = new List<int[]>();
            routes.Add(new int[] { 0, 0, 0 });
            for (var i = 0; i < n; i++)
            {
                routes.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            }

            for (var i = 0; i < routes.Count - 1; i++)
            {
                var tDiff = routes[i + 1][0] - routes[i][0];
                var dDiff = Math.Abs(routes[i][1] - routes[i + 1][1])
                                + Math.Abs(routes[i][2] - routes[i + 1][2]);
                if (dDiff > tDiff || !(tDiff % 2 == 0 && dDiff % 2== 0)
                    && !(tDiff % 2 == 1 && dDiff % 2 == 1))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}

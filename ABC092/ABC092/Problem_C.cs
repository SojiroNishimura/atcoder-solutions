using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC092
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
            var n = int.Parse(Console.ReadLine());
            var tmp = Console.ReadLine().Split().Select(int.Parse).ToList();
            var spots = new List<int> { 0 };
            spots.AddRange(tmp);
            spots.Add(0);

            var d = 0;
            for (var i = 1; i < spots.Count; i++)
            {
                d += Math.Abs(spots[i] - spots[i - 1]);
            }

            for (var i = 1; i < spots.Count - 1; i++)
            {
                var total = d - Math.Abs(spots[i - 1] - spots[i])
                  - Math.Abs(spots[i] - spots[i + 1])
                  + Math.Abs(spots[i - 1] - spots[i + 1]);
                Console.WriteLine($"{total}");
            }
        }
    }
}

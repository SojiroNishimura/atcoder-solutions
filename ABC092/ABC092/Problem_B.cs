using System;
using System.Linq;

namespace ABC092
{
    public class Problem_B
    {
        public Problem_B()
        {
            var reader = new System.IO.StreamReader("Inputs_B.txt");
            Console.SetIn(reader);
            Console.WriteLine("Problem_B");
        }

        public void Solve()
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int d = input[0], x = input[1];
            var eaten = 0;
            var a = new int[n];
            for (var i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

            for (var i = 0; i < d; i++)
            {
                foreach (var num in a)
                {
                    if (i * num + 1 <= d) eaten++;
                }
                //Console.WriteLine($"eaten:{eaten}");
            }
            Console.WriteLine($"{x + eaten}");
        }
    }
}

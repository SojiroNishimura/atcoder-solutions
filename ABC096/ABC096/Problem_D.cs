using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC096
{
    public class Problem_D
    {
        public Problem_D()
        {
            var reader = new System.IO.StreamReader("Inputs_D.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_D");
            var N = int.Parse(Console.ReadLine());
            var primes = FindPrimesBy(55555);
            var ans = primes.Where(p => p % 5 == 1).Take(N).ToArray();
            Console.WriteLine($"{string.Join(" ", ans)}");
        }

        private int[] FindPrimesBy(int n)
        {
            var sieve = new bool[n + 1];
            var primes = new List<int>();
            for (var i = 2; i <= n; i++)
            {
                if (!sieve[i])
                {
                    primes.Add(i);
                    for (var j = 1; i * j <= n; j++)
                        sieve[i * j] = true;
                }
            }
            return primes.ToArray();
        }
    }
}

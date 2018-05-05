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
            var primes = new List<int>();

            for (var i = 2; i < 55555; i++)
                if (isPrime(i)) primes.Add(i);

            var ans = primes.FindAll(p => p % 5 == 1).Take(N).ToArray();
            Console.WriteLine($"{string.Join(" ", ans)}");
        }

        private bool isPrime(int n)
        {
            for (var i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}

using System;
using System.Linq;

namespace Problem_C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var n = int.Parse(Console.ReadLine());
            var upper = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var lower = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var max = 0;
            for (var i = 0; i < n; i++)
            {
                var upperSum = upper.Take(i + 1).Sum();
                var lowerSum = lower.Skip(i).Take(n - i).Sum();
                max = Math.Max(max, upperSum + lowerSum);
            }
            Console.WriteLine($"{max}");
        }
    }
}

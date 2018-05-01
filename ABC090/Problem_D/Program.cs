using System;

namespace Problem_D
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = inputs[0], K = inputs[1];

            long total = 0;
            for (var b = 1; b <= N; b++)
            {
                var p = N / b;
                var r = N % b;
                total += K == 0 ? p * (Math.Max(b - K, 0)) + r
                    : p * Math.Max(b - K, 0) + Math.Max(0, r - (K - 1));
            }
            Console.WriteLine($"{total}");
        }
    }
}

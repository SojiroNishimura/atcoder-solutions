using System;

namespace Problem_C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long n = inputs[0], m = inputs[1];
            if (n == 1 && m == 1) Console.WriteLine("1");
            else if (n == 1) Console.WriteLine($"{m - 2}");
            else if (m == 1) Console.WriteLine($"{n - 2}");
            else Console.WriteLine($"{(n - 2) * (m - 2)}");
        }
    }
}

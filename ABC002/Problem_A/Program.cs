using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            string[] input = Console.ReadLine().Split(' ');
            var a = int.Parse(input[0]);
            var b = int.Parse(input[1]);
            Console.WriteLine($"{Math.Max(a, b)}");
        }
    }
}

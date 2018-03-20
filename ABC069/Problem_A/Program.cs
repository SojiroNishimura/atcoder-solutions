using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine($"{(input[0] - 1) * (input[1] - 1)}");
        }
    }
}

using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            var tree = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tree - 1}");
        }
    }
}

using System;
using System.Linq;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            int[] inputs = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            Console.WriteLine($"{Math.Ceiling((inputs[0] + inputs[1]) / 2d)}");
        }
    }
}
using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            var h1 = int.Parse(Console.ReadLine());
            var h2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{h1 - h2}");
        }
    }
}

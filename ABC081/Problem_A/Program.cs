using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var input = Console.ReadLine();
            var count = 0;
            foreach (var c in input)
            {
                if (c == '1') count++;
            }
            Console.WriteLine($"{count}");
        }
    }
}
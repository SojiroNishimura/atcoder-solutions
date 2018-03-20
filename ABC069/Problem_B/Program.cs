using System;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var str = Console.ReadLine();
            Console.WriteLine($"{str[0]}{str.Length - 2}{str[str.Length - 1]}");
        }
    }
}

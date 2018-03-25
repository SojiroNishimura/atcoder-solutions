using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var s = Console.ReadLine();
            Console.WriteLine($"{s.Replace("2017", "2018")}");
        }
    }
}
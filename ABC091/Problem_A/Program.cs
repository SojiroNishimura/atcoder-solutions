using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (line[0] + line[1] >= line[2]) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

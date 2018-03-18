using System;
using System.Linq;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var count = 0;
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (var i = input[0]; i <= input[1]; i++)
            {
                var numStr = i.ToString();
                if (numStr.Equals(string.Concat(numStr.Reverse()))) count++;
            }
            Console.WriteLine($"{count}");
        }
    }
}
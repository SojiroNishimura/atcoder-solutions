using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            var done = int.Parse(Console.ReadLine());
            var sum = 0;
            for (var i = 1; i <= done; i++)
            {
                sum += 10000 * i;
            }
            var salary = Math.Round(sum / (double)done);
            Console.WriteLine($"{salary}");
        }
    }
}

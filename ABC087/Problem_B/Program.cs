using System;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var y500 = int.Parse(Console.ReadLine());
            var y100 = int.Parse(Console.ReadLine());
            var y50 = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());

            var count = 0;
            for (var i = 0; i <= y500; i++)
            {
                for (var j = 0; j <= y100; j++)
                {
                    for (var k = 0; k <= y50; k++)
                    {
                        if (500 * i + 100 * j + 50 * k == x) count++;
                    }
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}

using System;

namespace ABC092
{
    public class Problem_D
    {
        const int SIZE = 100;
        const int HALF = SIZE / 2;

        public Problem_D()
        {
            var reader = new System.IO.StreamReader("Inputs_D.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_D");
            var grid = new char[SIZE][];
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int white = inputs[0], black = inputs[1];
            for (var i = 0; i < SIZE; i++)
            {
                var line = new char[SIZE];
                for (var j = 0; j < SIZE; j++)
                {
                    if (j < HALF) line[j] = '.';
                    else line[j] = '#';
                }
                grid[i] = line;
            }

            for (var b = 0; b < black - 1; b++)
            {
                var col = (b * 2) % HALF;
                var row = (b * 2) >= HALF ? 1 + ((b * 2) / HALF) * 2 : 1;
                grid[row][col] = '#';
            }

            for (var w = 0; w < white - 1; w++)
            {
                var col = (HALF + 1) + (w * 2) % HALF;
                var row = col >= HALF ? 1 + ((w * 2) / HALF) * 2 : 1;
                grid[row][col] = '.';
            }

            Console.WriteLine($"{white} {black}");
            Console.WriteLine($"{SIZE} {SIZE}");
            for (var i = 0; i < SIZE; i++)
            {
                Console.WriteLine(string.Join("", grid[i]));
            }
        }
    }
}

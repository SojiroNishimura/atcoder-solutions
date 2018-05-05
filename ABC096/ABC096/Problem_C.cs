using System;

namespace ABC096
{
    public class Problem_C
    {
        static readonly int[] di = { 1, -1, 0, 0 };
        static readonly int[] dj = { 0, 0, 1, -1 };

        public Problem_C()
        {
            var reader = new System.IO.StreamReader("Inputs_C.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_C");
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int H = inputs[0], W = inputs[1];
            var grid = new char[H, W];
            for (var i = 0; i < H; i++)
            {
                var line = Console.ReadLine();
                for (var j = 0; j < W; j++) grid[i, j] = line[j];
            }

            for (var i = 0; i < H; i++)
            {
                for (var j = 0; j < W; j++)
                {
                    if (grid[i, j] == '.') continue;
                    var isDrawable = false;
                    for (var k = 0; k < 4; k++)
                    {
                        var i2 = i + di[k];
                        var j2 = j + dj[k];
                        if (i2 >= 0 && i2 < H
                            && j2 >= 0 && j2 < W
                            && grid[i2, j2] == '#')
                        {
                            isDrawable = true;
                        }
                    }
                    if (!isDrawable)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
            }
            Console.WriteLine("Yes");
        }
    }
}

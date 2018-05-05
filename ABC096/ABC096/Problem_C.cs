using System;

namespace ABC096
{
    public class Problem_C
    {
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
                    if (!findDrawable(i, j, grid))
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
            }
            Console.WriteLine("Yes");
        }

        private bool findDrawable(int h, int w, char[,] grid)
        {
            var isDrawable = false;
            if (h - 1 >= 0) isDrawable |= grid[h - 1, w] == '#';
            if (w - 1 >= 0) isDrawable |= grid[h, w - 1] == '#';
            if (h + 1 < grid.GetLength(0)) isDrawable |= grid[h + 1, w] == '#';
            if (w + 1 < grid.GetLength(1)) isDrawable |= grid[h, w + 1] == '#';
            return isDrawable;
        }
    }
}

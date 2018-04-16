using System;

namespace ABC075
{
    public class Problem_B
    {
        public Problem_B()
        {
            var reader = new System.IO.StreamReader("Inputs_B.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_B");

            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int h = inputs[0], w = inputs[1];
            var grid = new char[h, w];
            for (var i = 0; i < h; i++)
            {
                var s = Console.ReadLine();
                for (var j = 0; j < s.Length; j++) grid[i, j] = s[j];
            }

            int[] dx = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int[] dy = { -1, -1, 0, 1, 1, 1, 0, -1 };
            for (var i = 0; i < h; i++)
            {
                for (var j = 0; j < w; j++)
                {
                    var count = 0;
                    for (var k = 0; k < dx.Length; k++)
                    {
                        if (i + dy[k] >= 0 && i + dy[k] < h
                            && j + dx[k] >= 0 && j + dx[k] < w
                            && grid[i + dy[k], j + dx[k]] == '#')
                        {
                            count++;
                        }
                    }
                    if (grid[i, j] == '.') grid[i, j] = Convert.ToString(count)[0];
                    Console.Write($"{grid[i, j]}");
                }
                Console.Write("\n");
            }
        }
    }
}

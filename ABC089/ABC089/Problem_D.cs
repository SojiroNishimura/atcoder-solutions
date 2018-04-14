using System;

namespace ABC089
{
    public class Problem_D
    {
        public Problem_D()
        {
            var reader = new System.IO.StreamReader("Inputs_D.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_D");
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int h = inputs[0], w = inputs[1], d = inputs[2];
            var grid = new Tuple<int, int>[(h * w) + 1];
            for (var i = 0; i < h; i++)
            {
                var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (var j = 0; j < line.Length; j++) grid[line[j]] = Tuple.Create(i + 1, j + 1);
            }
            //for (var i = 1; i < grid.Length; i++) Console.WriteLine($"{i}({grid[i].Item1}, {grid[i].Item2})");
            var dist = new int[(h * w) + 1];
            for (var i = d + 1; i <= h * w; i++)
            {
                dist[i] = dist[i - d] + Math.Abs(grid[i].Item1 - grid[i - d].Item1) + Math.Abs(grid[i].Item2 - grid[i - d].Item2);
                //Console.WriteLine($"dist[{i}]:{dist[i]}, dist[{i - d}]:{dist[i - d]}");
            }

            var q = int.Parse(Console.ReadLine());
            for (var i = 0; i < q; i++)
            {
                var move = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int l = move[0], r = move[1];
                Console.WriteLine($"{dist[r] - dist[l]}");
            }
        }
    }
}

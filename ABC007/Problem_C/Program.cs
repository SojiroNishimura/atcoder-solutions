using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_C
{
    class MainClass
    {
        const int INF = int.MaxValue;

        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var size = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var start = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var goal = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var maze = new char[size[0], size[1]];

            for (var i = 0; i < size[0]; i++)
            {
                var line = Console.ReadLine();
                for (var j = 0; j < line.Length; j++)
                {
                    maze[i, j] = line[j];
                }
            }

            var dist = new int[size[0], size[1]];
            for (var i = 0; i < size[0]; i++)
            {
                for (var j = 0; j < size[1]; j++)
                {
                    dist[i, j] = INF;
                }
            }

            dist[start[0] - 1, start[1] - 1] = 0;
            var q = new Queue<Tuple<int, int>>();
            q.Enqueue(Tuple.Create(start[0] - 1, start[1] - 1));
            while (q.Any())
            {
                var curr = q.Dequeue();
                var x = curr.Item1;
                var y = curr.Item2;
                //Console.WriteLine($"curr: {x} {y}");

                if (x - 1 >= 0 && dist[x - 1, y] == INF && maze[x - 1, y] == '.')
                {
                    dist[x - 1, y] = dist[x, y] + 1;
                    q.Enqueue(Tuple.Create(x - 1, y));
                }
                if (y + 1 < size[1] && dist[x, y + 1] == INF && maze[x, y + 1] == '.')
                {
                    dist[x, y + 1] = dist[x, y] + 1;
                    q.Enqueue(Tuple.Create(x, y + 1));
                }
                if (x + 1 < size[0] && dist[x + 1, y] == INF && maze[x + 1, y] == '.')
                {
                    dist[x + 1, y] = dist[x, y] + 1;
                    q.Enqueue(Tuple.Create(x + 1, y));
                }
                if (y - 1 >= 0 && dist[x, y - 1] == INF && maze[x, y - 1] == '.')
                {
                    dist[x, y - 1] = dist[x, y] + 1;
                    q.Enqueue(Tuple.Create(x, y - 1));
                }
            }
            Console.WriteLine($"{dist[goal[0] - 1, goal[1] - 1]}");

            //for (var i = 0; i < size[0]; i++)
            //{
            //    for (var j = 0; j < size[1]; j++)
            //    {
            //        Console.Write($"{dist[i, j]} ");
            //    }
            //    Console.Write("\n\n");
            //}

            for (var i = 0; i < size[0]; i++)
            {
                for (var j = 0; j < size[1]; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}

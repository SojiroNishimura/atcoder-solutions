using System;
using System.Linq;

namespace ABC075
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
            int N = inputs[0], M = inputs[1];

            var from = new int[M];
            var to = new int[M];
            var matrix = new int[N, N];
            for (var i = 0; i < M; i++)
            {
                var edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                from[i] = edge[0] - 1;
                to[i] = edge[1] - 1;
                matrix[from[i], to[i]] = matrix[to[i], from[i]] = 1;
            }

            var count = 0;
            // Loop through all edges
            for (var i = 0; i < M; i++)
            {
                // Check how it works when each edge is removed
                matrix[from[i], to[i]] = matrix[to[i], from[i]] = 0;

                var visited = new bool[N];
                Dfs(N, i, matrix, visited);
                // Count up if there are unreachable vertexes
                if (visited.Contains(false)) count++;

                // Resume original state
                matrix[from[i], to[i]] = matrix[to[i], from[i]] = 1;
            }
            Console.WriteLine($"{count}");
        }

        private void Dfs(int vCount, int v, int[,] matrix, bool[] visited)
        {
            visited[v] = true;
            for (var i = 0; i < vCount; i++)
            {
                if (matrix[v, i] == 0) continue;
                if (visited[i]) continue;
                Dfs(vCount, i, matrix, visited);
            }
        }
    }
}

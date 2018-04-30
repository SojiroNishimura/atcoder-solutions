using System;

namespace ABC065
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
            var N = int.Parse(Console.ReadLine());
            var a = new int[N];
            for (var i = 0; i < N; i++) a[i] = int.Parse(Console.ReadLine());

            var pressed = new bool[N];
            Console.WriteLine($"{FindAns(0, a, pressed, 0)}");
        }

        private int FindAns(int next, int[] paths, bool[] visited, int count)
        {
            if (visited[next]) return -1;
            visited[next] = true;
            if (paths[next] == 2) return count + 1;
            else return FindAns(paths[next] - 1, paths, visited, ++count);
        }
    }
}

using System;

namespace ABC068
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
            var paths1 = new bool[N];
            var paths2 = new bool[N];

            for (var i = 0; i < M; i++)
            {
                var path = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int from = path[0] - 1, to = path[1] - 1;
                if (from == 0) paths1[to] = true;
                else if (to == N - 1) paths2[from] = true;
            }

            var isPossible = false;
            for (var i = 0; i < N; i++)
            {
                if (paths1[i] && paths2[i])
                {
                    isPossible = true;
                    break;
                }
            }
            if (isPossible) Console.WriteLine("POSSIBLE");
            else Console.WriteLine("IMPOSSIBLE");
        }
    }
}

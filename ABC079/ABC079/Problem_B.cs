using System;

namespace ABC079
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
            var n = int.Parse(Console.ReadLine());
            var dp = new long[86 + 1];
            dp[0] = 2;
            dp[1] = 1;
            for (var i = 2; i <= n; i++) dp[i] = dp[i - 1] + dp[i - 2];
            Console.WriteLine($"{dp[n]}");
        }
    }
}

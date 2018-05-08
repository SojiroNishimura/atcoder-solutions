using System;

namespace ABC065
{
    public class Problem_C
    {
		static readonly int DIV = 1000000007;

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

			if (Math.Abs(N - M) >= 2) Console.WriteLine("0");
			else
			{
				long ans = (FactorialMod(N, DIV) * FactorialMod(M, DIV)) % DIV;
				ans = N == M ? 2 * ans % DIV : ans;
				Console.WriteLine($"{ans}");
			}
		}

		private long FactorialMod(int num, int divider)
		{
			long ans = num;
			for (var i = num - 1; i > 1; i--)
			{
				ans = (ans * i) % divider;
			}
			return ans;
		}
    }
}

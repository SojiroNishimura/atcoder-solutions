using System;

namespace ABC068
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

            var ans = 1;
            while (ans <= N) ans <<= 1;
            Console.WriteLine($"{ans >> 1}");
        }

        public void Solve2()
        {
            Console.WriteLine("Problem_B");
            var N = int.Parse(Console.ReadLine());

            var max = 0;
            var ans = 1;
            for (var i = 1; i <= N; i++)
            {
                var count = 0;
                var tmp = i;
                while (tmp > 0)
                {
                    tmp /= 2;
                    count++;
                }
                if (count > max)
                {
                    ans = i;
                    max = count;
                }
            }
            Console.WriteLine($"{ans}");
        }
    }
}

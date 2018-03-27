using System;

namespace ABC083
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
            var nums = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long x = nums[0], y = nums[1];
            var i = 0;
            long num;
            for (i = 0; ; i++)
            {
                num = x * (long) Math.Pow(2, i);
                if (num > y) break;
            }
            Console.WriteLine($"{i}");
        }
    }
}

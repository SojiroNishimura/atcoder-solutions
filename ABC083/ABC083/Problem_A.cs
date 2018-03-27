using System;

namespace ABC083
{
    public class Problem_A
    {
        public Problem_A()
        {
            var reader = new System.IO.StreamReader("Inputs_A.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_A");
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int left = nums[0] + nums[1], right = nums[2] + nums[3];
            var ans = left == right ? "Balanced" : (left > right ? "Left" : "Right");
            Console.WriteLine(ans);
        }
    }
}

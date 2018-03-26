using System;
using System.Linq;

namespace ABC088
{
    public class Problem_C
    {
        public Problem_C()
        {
            var reader = new System.IO.StreamReader("Inputs_C.txt");
            Console.SetIn(reader);
            Console.WriteLine("Problem_C");
        }

        public void Solve()
        {
            var grid = new int[3][];
            for (var i = 0; i < 3; i++) grid[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (grid[0][0] + grid[1][1] + grid[2][2] == grid[0][1] + grid[1][2] + grid[2][0]
                && grid[0][0] + grid[1][1] + grid[2][2] == grid[0][2] + grid[1][0] + grid[2][1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

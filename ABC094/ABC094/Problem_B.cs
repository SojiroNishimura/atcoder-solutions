using System;

namespace ABC094
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
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0], m = inputs[1], x = inputs[2];
            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int l = 0, r = 0;
            foreach (var gate in a)
            {
                if (gate < x) l++;
                else r++;
            }
            Console.WriteLine($"{Math.Min(l, r)}");
        }
    }
}

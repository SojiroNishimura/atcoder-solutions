using System;

namespace ABC094
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
            var n = int.Parse(Console.ReadLine());
            var x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var y = new int[n];
            Array.Copy(x, y, x.Length);
            Array.Sort(y);

            foreach (var val in x)
            {
                if (val < y[n / 2]) Console.WriteLine($"{y[n / 2]}");
                else Console.WriteLine($"{y[(n / 2) - 1]}");
            }
        }
    }
}

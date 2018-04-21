using System;

namespace ABC095
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
            int A = inputs[0], B = inputs[1], C = inputs[2], X = inputs[3], Y = inputs[4];

            var total = 0;
            if (2 * C < A + B)
            {
                var min = Math.Min(X, Y);
                total += (2 * C) * min;
                if (X - min > 0) total += Math.Min(2 * C * (X - min), A * (X - min));
                if (Y - min > 0) total += Math.Min(2 * C * (Y - min), B * (Y - min));
            }
            else
            {
                total += A * X;
                total += B * Y;
            }
            Console.WriteLine($"{total}");
        }
    }
}

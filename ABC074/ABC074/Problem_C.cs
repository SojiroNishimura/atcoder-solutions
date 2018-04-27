using System;

namespace ABC074
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
            int A = inputs[0], B = inputs[1], C = inputs[2], D = inputs[3], E = inputs[4], F = inputs[5];

            var total = 0;
            var sugarTotal = 0;
            double maxDens = 0;
            for (var i = 0; 100 * A * i <= F; i++)
            {
                for (var j = 0; (100 * A * i) + (100 * B * j) <= F; j++)
                {
                    if (i == 0 && j == 0) continue;
                    var waterSum = (100 * A * i) + (100 * B * j);
                    for (var k = 0; waterSum + (C * k) <= F; k++)
                    {
                        for (var l = 0; waterSum + (C * k) + (D * l) <= F; l++)
                        {
                            var sugarSum = (C * k) + (D * l);
                            if (sugarSum > waterSum) continue;
                            double dens = ((double) sugarSum / waterSum);
                            if (dens <= E / 100d && dens >= maxDens)
                            {
                                maxDens = dens;
                                total = waterSum + sugarSum;
                                sugarTotal = sugarSum;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"{total} {sugarTotal}");
        }
    }
}

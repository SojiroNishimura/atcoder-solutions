using System;

namespace ABC093
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
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = nums[0], b = nums[1], c = nums[2];

            var m = Math.Max(a, Math.Max(b, c));
            var sum = a + b + c;
            if ((3 * m) % 2 == sum % 2) Console.WriteLine($"{((3 * m) - sum) / 2}");
            else Console.WriteLine($"{(3 * (m + 1) - sum) / 2}");
        }

        public void Solve_origin()
        {
            Console.WriteLine("Problem_C");
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = nums[0], b = nums[1], c = nums[2];

            var count = 0;
            while (!(a == b && b == c))
            {
                var max = Math.Max(a, Math.Max(b, c));
                if (max == a)
                {
                    var db = a - b;
                    var dc = a - c;
                    if (db % 2 == 0 && dc % 2 == 1)
                    {
                        a += 1;
                        c += 1;
                        count++;
                    }
                    else if (db % 2 == 1 && dc % 2 == 0)
                    {
                        a += 1;
                        b += 1;
                        count++;
                    }
                    else 
                    {
                        var divB = db / 2;
                        var divC = dc / 2;
                        var remB = db % 2;
                        var remC = dc % 2;
                        b += 2 * divB + remB;
                        c += 2 * divC + remC;
                        count += divB + divC + remB;
                    }
                }
                else if (max == b)
                {
                    var da = b - a;
                    var dc = b - c;
                    if (da % 2 == 0 && dc % 2 == 1)
                    {
                        b += 1;
                        c += 1;
                        count++;
                    }
                    else if (da % 2 == 1 && dc % 2 == 0)
                    {
                        a += 1;
                        b += 1;
                        count++;
                    }
                    else
                    {
                        var divA = da / 2;
                        var divC = dc / 2;
                        var remA = da % 2;
                        var remC = dc % 2;
                        a += 2 * divA + remA;
                        c += 2 * divC + remC;
                        count += divA + divC + remA;
                    }
                }
                else
                {
                    var da = c - a;
                    var db = c - b;
                    if (da % 2 == 0 && db % 2 == 1)
                    {
                        b += 1;
                        c += 1;
                        count++;
                    }
                    else if (da % 2 == 1 && db % 2 == 0)
                    {
                        a += 1;
                        c += 1;
                        count++;
                    }
                    else
                    {
                        var divA = da / 2;
                        var divB = db / 2;
                        var remA = da % 2;
                        var remB = db % 2;
                        a += 2 * divA + remA;
                        b += 2 * divB + remB;
                        count += divA + divB + remA;
                    }
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}

using System;
using System.Linq;

namespace ABC089
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
            var names = new string[n];
            long mNum = 0, aNum = 0, rNum = 0, cNum = 0, hNum = 0;

            for (var i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                if (name.First() == 'M')
                {
                    mNum++;
                }
                else if (name.First() == 'A')
                {
                    aNum++;
                }
                else if (name.First() == 'R')
                {
                    rNum++;
                }
                else if (name.First() == 'C')
                {
                    cNum++;
                }
                else if (name.First() == 'H')
                {
                    hNum++;
                }
            }
            long ans = (mNum * aNum * rNum) + (mNum * aNum * cNum) + (mNum * aNum * hNum)
                + (mNum * rNum * cNum) + (mNum * rNum * hNum) + (mNum * cNum * hNum)
                + (aNum * rNum * cNum) + (aNum * rNum * hNum) + (aNum * cNum * hNum)
                + (rNum * cNum * hNum);
            Console.WriteLine($"{ans}");
        }
    }
}

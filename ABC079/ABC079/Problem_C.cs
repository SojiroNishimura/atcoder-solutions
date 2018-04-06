using System;
using System.Linq;
using System.Data;

namespace ABC079
{
    public class Problem_C
    {
        char[] op = new char[] { '+', '-' };

        public Problem_C()
        {
            var reader = new System.IO.StreamReader("Inputs_C.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_C");
            var nums = Console.ReadLine().Select(c => (int)Char.GetNumericValue(c)).ToArray();
            if (nums[0] + nums[1] + nums[2] + nums[3] == 7) Console.WriteLine($"{nums[0]}+{nums[1]}+{nums[2]}+{nums[3]}=7");
            else if (nums[0] + nums[1] + nums[2] - nums[3] == 7) Console.WriteLine($"{nums[0]}+{nums[1]}+{nums[2]}-{nums[3]}=7");
            else if (nums[0] + nums[1] - nums[2] + nums[3] == 7) Console.WriteLine($"{nums[0]}+{nums[1]}-{nums[2]}+{nums[3]}=7");
            else if (nums[0] + nums[1] - nums[2] - nums[3] == 7) Console.WriteLine($"{nums[0]}+{nums[1]}-{nums[2]}-{nums[3]}=7");
            else if (nums[0] - nums[1] + nums[2] + nums[3] == 7) Console.WriteLine($"{nums[0]}-{nums[1]}+{nums[2]}+{nums[3]}=7");
            else if (nums[0] - nums[1] + nums[2] - nums[3] == 7) Console.WriteLine($"{nums[0]}-{nums[1]}+{nums[2]}-{nums[3]}=7");
            else if (nums[0] - nums[1] - nums[2] + nums[3] == 7) Console.WriteLine($"{nums[0]}-{nums[1]}-{nums[2]}+{nums[3]}=7");
            else if (nums[0] - nums[1] - nums[2] - nums[3] == 7) Console.WriteLine($"{nums[0]}-{nums[1]}-{nums[2]}-{nums[3]}=7");
        }

        public void Solve2()
        {
            Console.WriteLine("Problem_C");
            var nums = Console.ReadLine().Select(c => (int) Char.GetNumericValue(c)).ToArray();
            var dt = new DataTable();
            string exp;
            for (var i = 0; i < op.Length; i++)
            {
                for (var j = 0; j < op.Length; j++)
                {
                    for (var k = 0; k < op.Length; k++)
                    {
                        exp = $"{nums[0]}{op[i]}{nums[1]}{op[j]}{nums[2]}{op[k]}{nums[3]}";
                        if ((int) dt.Compute(exp, "") == 7)
                        {
                            Console.WriteLine(exp + "=7");
                            return;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace ABC075
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
            var inputs = Console.ReadLine().Split();
            if (inputs[0] == inputs[1]) Console.WriteLine(inputs[2]);
            else if (inputs[0] == inputs[2]) Console.WriteLine(inputs[1]);
            else if (inputs[1] == inputs[2]) Console.WriteLine(inputs[0]);
        }
    }
}

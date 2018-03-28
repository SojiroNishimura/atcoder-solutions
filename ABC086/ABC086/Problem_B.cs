using System;

namespace ABC086
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
            var input = Console.ReadLine().Split();
            var s = string.Join("", input);
            var root = Math.Floor(Math.Sqrt(int.Parse(s)));
            if ((root * root).ToString() == s) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
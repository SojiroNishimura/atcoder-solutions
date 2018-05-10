using System;
using System.Collections.Generic;

namespace ABC063
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
			var s = Console.ReadLine();
			var ss = new HashSet<char>(s);
			if (s.Length == ss.Count) Console.WriteLine("yes");
			else Console.WriteLine("no");
		}
    }
}

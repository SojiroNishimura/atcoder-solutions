using System;

namespace ABC061
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
			var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int A = inputs[0], B = inputs[1], C = inputs[2];
            if (C >= A && C <= B) Console.WriteLine("Yes");
            else Console.WriteLine("No");
		}
    }
}
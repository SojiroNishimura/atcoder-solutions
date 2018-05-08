using System;

namespace ABC063
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
            if (inputs[0] + inputs[1] < 10) Console.WriteLine($"{inputs[0] + inputs[1]}");
            else Console.WriteLine("error");
		}
    }
}
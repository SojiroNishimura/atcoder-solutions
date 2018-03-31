using System;
namespace ABC084
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
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{48 - n}");            
        }
    }
}

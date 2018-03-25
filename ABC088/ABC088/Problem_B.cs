using System;

namespace ABC088
{
    public class Problem_B
    {
        public Problem_B()
        {
            var reader = new System.IO.StreamReader("Inputs_B.txt");
            Console.SetIn(reader);
            Console.WriteLine("Problem_B");
        }

        public void Solve()
        {
            var n = int.Parse(Console.ReadLine());
            var cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(cards, (a, b) => b - a);
            var alice = 0;
            var bob = 0;
            for (var i = 0; i < n; i++)
            {
                if ((i + 1) % 2 == 1) alice += cards[i];
                else bob += cards[i];
            }
            Console.WriteLine($"{alice - bob}");
        }
    }
}
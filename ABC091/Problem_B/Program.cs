using System;
using System.Collections.Generic;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var n = int.Parse(Console.ReadLine());
            var blue = new Dictionary<string, int>();
            for (var i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                if (blue.ContainsKey(word)) blue[word] += 1;
                else blue.Add(word, 1);
            }

            var m = int.Parse(Console.ReadLine());
            var red = new Dictionary<string, int>();
            for (var i = 0; i < m; i++)
            {
                var word = Console.ReadLine();
                if (red.ContainsKey(word)) red[word] += 1;
                else red.Add(word, 1);
            }

            var total = 0;
            foreach (var e in blue)
            {
                if (red.ContainsKey(e.Key))
                {
                    total = Math.Max(total, e.Value - red[e.Key]);
                }
                else
                {
                    total = Math.Max(total, e.Value);
                }
            }
            Console.WriteLine($"{total}");
        }
    }
}

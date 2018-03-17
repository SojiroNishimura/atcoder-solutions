using System;
using System.Collections.Generic;

namespace Problem_C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var n = int.Parse(Console.ReadLine());
            var red = new List<Tuple<int, int>>();
            var blue = new List<Tuple<int, int>>();
            for (var i = 0; i < n; i++)
            {
                var p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                red.Add(Tuple.Create(p[0], p[1]));
            }
            for (var i = 0; i < n; i++)
            {
                var p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                blue.Add(Tuple.Create(p[0], p[1]));
            }

            red.Sort();
            blue.Sort((t1, t2) => t1.Item2 < t2.Item2 ? -1 : 1);
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    //Console.WriteLine($"r:{red[i]} b:{blue[j]}");
                    if (blue[j] != null && red[i].Item1 < blue[j].Item1 && red[i].Item2 < blue[j].Item2)
                    {
                        count++;
                        blue[j] = null;
                        break;
                    }
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}

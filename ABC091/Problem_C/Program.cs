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
            blue.Sort();
            var count = 0;
            for (var i = 0; i < blue.Count; i++)
            {
                var maxY = int.MinValue;
                for (var j = 0; j < red.Count; j++)
                {
                    if (red[j] != null &&
                        red[j].Item1 < blue[i].Item1 && red[j].Item2 < blue[i].Item2)
                    {
                        maxY = Math.Max(maxY, red[j].Item2);
                    }
                    //Console.WriteLine($"r:{red[j]} b:{blue[i]}");
                }
                if (maxY > int.MinValue) count++;
                for (var k = 0; k < red.Count; k++)
                {
                    if (red[k] != null && red[k].Item2 == maxY)
                    {
                        red[k] = null;
                        break;
                    }
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}

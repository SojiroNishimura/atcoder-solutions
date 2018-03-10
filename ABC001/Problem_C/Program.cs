using System;

namespace Problem_C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            string[] input = Console.ReadLine().Split(' ');
            var angle = int.Parse(input[0]);
            var dist = int.Parse(input[1]);
            string[] directions = { "N", "NNE", "NE", "ENE", "E", "ESE",
                "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW" };
            double[] wthresholds = { 0.25, 1.55, 3.35, 5.45, 7.95, 10.75, 13.85,
                17.15, 20.75, 24.45, 28.45, 32.65, double.MaxValue };

            double wpower = Math.Round(dist / 60d + 0.0001, 1, MidpointRounding.AwayFromZero);
            var w = 0;
            for (var j = 0; j < wthresholds.Length; j++)
            {
                if (wpower < wthresholds[j])
                {
                    w = j;
                    break;
                }
            }
            var dirIdx = ((angle * 10 + 1125) / 2250) % 16;
            var dir = w == 0 ? "C" : directions[dirIdx];
            Console.WriteLine($"{dir} {w}");
        }
    }
}

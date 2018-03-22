using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var reader = new System.IO.StreamReader("Inputs.txt");
        Console.SetIn(reader);

        var n = int.Parse(Console.ReadLine());
        var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var count = int.MaxValue;
        for (var i = 0; i < n; i++)
        {
            var tmp = 0;
            while (input[i] % 2 == 0)
            {
                input[i] /= 2;
                tmp++;
            }
            count = Math.Min(count, tmp);
        }
        Console.WriteLine($"{count}");
    }
}

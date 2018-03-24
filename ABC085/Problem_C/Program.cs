using System;

class Solution
{
    public static void Main(string[] args)
    {
        var reader = new System.IO.StreamReader("Inputs.txt");
        Console.SetIn(reader);

        var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = input[0], y = input[1];
        int n10000 = -1, n5000 = -1, n1000 = -1;
        for (var i = 0; i <= n; i++)
        {
            for (var j = 0; i + j <= n; j++)
            {
                var c = n - (i + j);
                if ((10000 * i) + (5000 * j) + (1000 * c) == y)
                {
                    n10000 = i;
                    n5000 = j;
                    n1000 = c;
                    goto END;
                }
            }
        }
        END:;
        Console.WriteLine($"{n10000} {n5000} {n1000}");
    }
}

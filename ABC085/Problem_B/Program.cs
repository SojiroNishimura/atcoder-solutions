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
            var mochis = new int[n];
            for (var i = 0; i < n; i++) mochis[i] = int.Parse(Console.ReadLine());

            var mochiSet = new HashSet<int>();
            foreach (var m in mochis)
            {
                mochiSet.Add(m);
            }
            Console.WriteLine($"{mochiSet.Count}");
        }
    }
}
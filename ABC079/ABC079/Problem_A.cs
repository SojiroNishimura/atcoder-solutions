﻿using System;

namespace ABC079
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
            var n = Console.ReadLine();
            if ((n[0] == n[1] && n[0] == n[2]) || (n[1] == n[2] && n[1] == n[3])) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

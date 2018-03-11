using System;
using System.Collections.Generic;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            var s = Console.ReadLine();
            var t = Console.ReadLine();
            var chars = new HashSet<char>(new char[] { 'a', 't', 'c', 'o', 'd', 'e', 'r' });
            var ans = "You can win";
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                {
                    continue;
                }
                else if ((s[i] == '@' && chars.Contains(t[i])) ||
                         (t[i] == '@' && chars.Contains(s[i])))
                {
                    continue;
                }
                else
                {
                    ans = "You will lose";
                }
            }
            Console.WriteLine(ans);
        }
    }
}

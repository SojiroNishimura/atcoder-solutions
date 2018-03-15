using System;
using System.Linq;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var s = string.Join("", Console.ReadLine().OrderBy(c => c).ToArray());
            var t = string.Join("", Console.ReadLine().OrderByDescending(c => c).ToArray());
            if (s.CompareTo(t) < 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

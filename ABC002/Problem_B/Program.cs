using System;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            var str = Console.ReadLine();
            var ans = "";
            foreach (var c in str)
            {
                if (c == 'a' || c == 'i' || c == 'u' || c == 'e' || c == 'o')
                {
                    continue;
                }
                ans += c;
            }
            Console.WriteLine(ans);
        }
    }
}

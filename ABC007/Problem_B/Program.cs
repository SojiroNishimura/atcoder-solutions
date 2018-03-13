using System;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var str = Console.ReadLine();

            if (str.Length == 1 && str[0] == 'a')
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("a");
            }
        }
    }
}
using System;

namespace Problem_A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            const int N = 3;
            var str = "";
            for (var i = 0; i < N; i++)
            {
                var row = Console.ReadLine();
                for (var j = 0; j < N; j++)
                {
                    if (i == j) str += row[j];   
                }
            }
            Console.WriteLine(str);
        }
    }
}

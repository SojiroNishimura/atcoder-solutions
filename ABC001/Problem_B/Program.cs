using System;

namespace Problem_B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            System.Console.SetIn(reader);

            var dist = int.Parse(Console.ReadLine());
            var vv = 0;

            if (dist >= 100 && dist <= 5000)
            {
                vv = dist / 100;
            }
            else if (dist >= 6000 && dist <= 30000)
            {
                vv = (dist / 1000) + 50;
            }
            else if (dist >= 35000 && dist <= 70000)
            {
                vv = ((dist / 1000) - 30) / 5 + 80;
            }
            else if (dist > 70000)
            {
                vv = 89;
            }
            Console.WriteLine(vv.ToString("D2"));
        }
    }
}

using System;
namespace ABC084
{
    public class Problem_B
    {
        public Problem_B()
        {
            var reader = new System.IO.StreamReader("Inputs_B.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_B");
            var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[0], b = input[1];
            var s = Console.ReadLine();
            var ans = IsValidPostalCode(a, b, s) ? "Yes" : "No";
            Console.WriteLine(ans);
        }

        private bool IsValidPostalCode(int a, int b, string s)
        {
            for (var i = 0; i < a; i++)
            {
                if (s[i] < '0' || s[i] > '9') return false;
            }
            if (s[a] != '-') return false;
            for (var i = a + 1; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9') return false;
            }
            return true;
        }
    }
}

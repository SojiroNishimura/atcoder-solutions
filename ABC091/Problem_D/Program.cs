using System;

namespace Problem_D
{
    class MainClass
    {
        static readonly int BIT_NUM = 28;

        public static void Main(string[] args)
        {
            var reader = new System.IO.StreamReader("Inputs.txt");
            Console.SetIn(reader);

            var N = int.Parse(Console.ReadLine());
            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            long ans = 0;
            for (var i = 0; i <= BIT_NUM; i++)
            {
                var mask = (1 << i + 1) - 1;
                var maskedA = new int[N];
                var maskedB = new int[N];
                for (var j = 0; j < N; j++)
                {
                    maskedA[j] = a[j] & mask;
                    maskedB[j] = b[j] & mask;
                }
                Array.Sort(maskedB);

                var T = 1 << i;
                long parity = 0;
                for (var j = 0; j < N; j++)
                {
                    var num1 = LowerBound(maskedB, T - maskedA[j]);
                    var num2 = LowerBound(maskedB, 2 * T - maskedA[j]);
                    var num3 = LowerBound(maskedB, 3 * T - maskedA[j]);
                    //var num4 = LowerBound(maskedB, 4 * T - maskedA[j]);
                    parity += (num2 - num1) + (N - num3);
                }
                ans |= (parity & 1) << i; // Check if parity is Even or Odd
            }
            Console.WriteLine($"{ans}");
        }

        private static int LowerBound(int[] arr, int val)
        {
            int first = 0, last = arr.Length - 1, mid;
            while (first <= last)
            {
                mid = (first + last) >> 1;
                if (val > arr[mid]) first = mid + 1;
                else last = mid - 1;
            }
            return first;
        }
    }
}

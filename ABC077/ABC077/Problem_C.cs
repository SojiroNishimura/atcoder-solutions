using System;

namespace ABC077
{
    public class Problem_C
    {
        public Problem_C()
        {
            var reader = new System.IO.StreamReader("Inputs_C.txt");
            Console.SetIn(reader);
        }

        public void Solve()
        {
            Console.WriteLine("Problem_C");
            var N = int.Parse(Console.ReadLine());
            var top = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var middle = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var bottom = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(top);
            Array.Sort(bottom);

            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                long t = LowerBound(top, middle[i]);
                long b = UpperBound(bottom, middle[i]);
                if (b < N) ans += t * (N - b);
            }
            Console.WriteLine(ans);
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

        private static int UpperBound(int[] arr, int val)
        {
            int first = 0, last = arr.Length - 1, mid;
            while (first <= last)
            {
                mid = (first + last) >> 1;
                if (val >= arr[mid]) first = mid + 1;
                else last = mid - 1;
            }
            return first;
        }
    }
}

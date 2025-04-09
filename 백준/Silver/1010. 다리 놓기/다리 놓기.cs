using System;
using System.Text;

namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int t = int.Parse(sr.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                sw.WriteLine(Combination(M, N));
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }

        static long Combination(int M, int N)
        {
            // C(n, r) = n! / (r! * (n - r)!)
            // 최적화: C(n, r) = C(n, n - r)
            if (N > M - 1)
                N = M - N;
            long result = 1;
            for (int i = 0; i < N; i++)
            {
                result *= M - i;
                result /= i + 1;
            }
            return result;


        }
    }
}
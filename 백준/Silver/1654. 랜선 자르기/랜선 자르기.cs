using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 입력 받기
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int K = input[0];
        int N = input[1];

        long[] lanLengths = new long[K];
        for (int i = 0; i < K; i++)
        {
            lanLengths[i] = long.Parse(Console.ReadLine());
        }

        Console.WriteLine(MaxLanLength(K, N, lanLengths));
    }

    static long MaxLanLength(int K, int N, long[] lanLengths)
    {
        long start = 1;
        long end = lanLengths.Max();
        long result = 0;

        while (start <= end)
        {
            long mid = (start + end) / 2;
            long total = 0;

            foreach (var length in lanLengths)
            {
                total += length / mid;
            }

            if (total >= N)
            {
                result = mid; // 조건을 만족하므로 길이를 더 늘려봄
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return result;
    }
}

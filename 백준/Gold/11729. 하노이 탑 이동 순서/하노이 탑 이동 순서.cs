using System;
using System.Text;

namespace 백준
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            // 입력: 첫 번째 장대에 쌓인 원판의 개수 N
            int N = int.Parse(Console.ReadLine());

            // 총 이동 횟수 출력
            Console.WriteLine((int)Math.Pow(2, N) - 1);

            // 하노이 탑 이동 과정 출력
            Hanoi(N, 1, 3, 2);

            // StringBuilder에 저장된 결과를 한 번에 출력
            Console.Write(sb.ToString());
        }

        // 하노이 탑 재귀 함수
        static void Hanoi(int n, int first, int finish, int middle)
        {
            if (n == 1)
            {
                // 원판 1개를 first에서 finish로 이동
                sb.AppendLine($"{first} {finish}");
                return;
            }

            // n-1개의 원판을 first에서 middle로 이동
            Hanoi(n - 1, first, middle, finish);

            // 가장 큰 원판을 first에서 finish로 이동
            sb.AppendLine($"{first} {finish}");

            // n-1개의 원판을 middle에서 finish로 이동
            Hanoi(n - 1, middle, finish, first);
        }
    }
}
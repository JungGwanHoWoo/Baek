using System;

namespace 백준
{
    class Program
    {
        /// <summary>
        /// 주어진 범위에서 가운데 1/3 구간을 공백으로 만들고,
        /// 양쪽 1/3 구간에 대해 재귀적으로 같은 작업을 수행하는 함수
        /// </summary>
        static void Cantor(char[] line, int start, int length)
        {
            // 길이가 1이면 더 이상 쪼갤 수 없으므로 종료
            if (length == 1) return;

            // 현재 구간을 3등분 할 것이므로 1/3 길이를 구함
            int third = length / 3;

            // 가운데 1/3 구간을 공백으로 채움
            for (int i = start + third; i < start + 2 * third; i++)
            {
                line[i] = ' ';
            }

            // 왼쪽 1/3 구간에 대해 재귀 호출
            Cantor(line, start, third);

            // 오른쪽 1/3 구간에 대해 재귀 호출
            Cantor(line, start + 2 * third, third);
        }

        static void Main(string[] args)
        {
            string input;

            // EOF까지 반복
            while ((input = Console.ReadLine()) != null)
            {
                if (input == "") continue; // 빈 줄 방지

                int n = int.Parse(input);

                int pow = (int)Math.Pow(3, n);

                // 문자 배열을 만들고, 모두 '-'로 초기화
                char[] line = new char[pow];
                for (int i = 0; i < pow; i++)
                {
                    line[i] = '-';
                }

                // 칸토어 집합 구성 시작
                Cantor(line, 0, pow);

                // 결과 출력
                Console.WriteLine(new string(line));
            }
        }
    }
}

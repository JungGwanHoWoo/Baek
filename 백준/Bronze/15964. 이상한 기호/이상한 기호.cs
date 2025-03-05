using System;

class Program
{
    static void Main()
    {
        // 사용자 입력 받기
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        // 연산 수행
        int result = (A + B) * (A - B);

        // 결과 출력
        Console.WriteLine(result);
    }
}
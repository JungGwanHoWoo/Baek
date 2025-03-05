using System;

class Program
{
    // A＠B = (A+B) * (A-B)를 계산하는 함수 (long 타입 사용)
    static long CustomOperation(long A, long B)
    {
        return (A + B) * (A - B);
    }

    static void Main()
    {
        // 입력 받기
        string[] input = Console.ReadLine().Split();
        long A = long.Parse(input[0]); // long 타입으로 변경
        long B = long.Parse(input[1]); // long 타입으로 변경

        // 함수 호출 및 결과 출력
        Console.WriteLine(CustomOperation(A, B));
    }
}

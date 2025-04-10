using System;

class Program
{
    static void Main()
    {
        // 입력: 설탕의 무게 N(kg)을 입력받음
        int N = int.Parse(Console.ReadLine());

        // dp[i]는 i킬로그램을 만들기 위한 최소 봉지 수를 저장하는 배열
        // 모든 값을 충분히 큰 수(5001)로 초기화 (최대 N이 5000이므로 불가능한 값으로 설정)
        int[] dp = new int[N + 1];

        for (int i = 0; i <= N; i++)
        {
            dp[i] = 5001; // 초기에는 모두 불가능한 상태로 간주
        }

        dp[0] = 0; // 0kg은 아무 봉지도 필요 없으므로 0으로 설정

        // 3kg, 5kg 봉지를 이용해 ikg을 만들 수 있는 최소 봉지 수를 계산
        for (int i = 3; i <= N; i++)
        {
            // 3kg 봉지를 하나 추가하는 경우
            if (i >= 3 && dp[i - 3] != 5001)
                dp[i] = Math.Min(dp[i], dp[i - 3] + 1);

            // 5kg 봉지를 하나 추가하는 경우
            if (i >= 5 && dp[i - 5] != 5001)
                dp[i] = Math.Min(dp[i], dp[i - 5] + 1);
        }

        // 최종 결과 출력
        // 만약 dp[N]이 여전히 5001이라면 정확하게 Nkg을 만들 수 없는 경우
        if (dp[N] == 5001)
            Console.WriteLine(-1); // 만들 수 없으면 -1 출력
        else
            Console.WriteLine(dp[N]); // 최소 봉지 수 출력
    }
}

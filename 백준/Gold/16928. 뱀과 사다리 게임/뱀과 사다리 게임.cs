using System;
using System.Collections.Generic;

class Program
{
    static int[] moves = new int[101]; // 사다리/뱀 이동 정보
    static int[] dist = new int[101];  // 도달 횟수 (0은 미방문)

    static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int N = int.Parse(nm[0]);
        int M = int.Parse(nm[1]);

        // 사다리 정보 입력
        for (int i = 0; i < N; i++)
        {
            var line = Console.ReadLine().Split();
            int from = int.Parse(line[0]);
            int to = int.Parse(line[1]);
            moves[from] = to;
        }

        // 뱀 정보 입력
        for (int i = 0; i < M; i++)
        {
            var line = Console.ReadLine().Split();
            int from = int.Parse(line[0]);
            int to = int.Parse(line[1]);
            moves[from] = to;
        }

        Console.WriteLine(Solve());
    }

    static int Solve()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        dist[1] = 1;

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            for (int dice = 1; dice <= 6; dice++)
            {
                int next = current + dice;
                if (next > 100) continue;

                // 사다리나 뱀에 의해 이동
                if (moves[next] != 0) next = moves[next];

                if (dist[next] == 0)
                {
                    dist[next] = dist[current] + 1;
                    queue.Enqueue(next);

                    if (next == 100)
                        return dist[100] - 1; // 시작을 1로 했으므로 -1
                }
            }
        }

        return -1;
    }
}

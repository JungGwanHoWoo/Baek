using System;
using System.Text;

namespace 백준
{
    class Program
    {
        static int[,] map; //입력값의 좌표를 나타낼 2차원 배열
        static bool[,] visited; // 방문여부를 확인할 2차원 배열
        static int n; // 지도의 크기 최조의 입력값으로 정의

        //이동 방향 상하좌우
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };

        static List<int> complexSizes = new List<int>();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine()); //지도의 크기를 입력받는다
            map = new int[n, n]; //지도의 크기만큼 2차원 배열을 생성한다.
            visited = new bool[n, n]; //방문여부를 확인할 2차원 배열을 생성한다.

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine(); //지도의 정보를 입력받는다.
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = input[j] - '0'; //입력받은 문자열을 정수형으로 변환하여 2차원 배열에 저장한다.
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (map[i, j] == 1 && !visited[i, j]) //아파트 단지의 시작점인 1을 찾는다.
                    {
                        int count = 0; //단지의 크기를 저장할 변수
                        DFS(i, j, ref count); //DFS를 통해 단지의 크기를 구한다.
                        complexSizes.Add(count); //구한 단지의 크기를 리스트에 추가한다.
                    }
                }
            }

            System.Console.WriteLine(complexSizes.Count); //단지의 개수를 출력한다.

            //단지의 집수를 오름차순으로 정렬한다
            complexSizes.Sort();
            //단지의 집수를 출력한다.
            foreach (int size in complexSizes)
            {
                System.Console.WriteLine(size);
            }
        }

        static void DFS(int x, int y, ref int count)
        {
            //현재 좌표를 방문 처리한다.
            visited[x, y] = true;
            //단지의 크기를 증가시킨다.
            count++;


            for (int dir = 0; dir < 4; dir++)
            {
                //상하좌우로 이동할 좌표를 계산한다.
                int nx = x + dx[dir];
                int ny = y + dy[dir];

                //이동할 좌표가 유효한지 확인한다.
                if (nx >= 0 && nx < n && ny >= 0 && ny < n)
                {
                    //이동할 좌표가 1이고 방문하지 않았다면 DFS를 재귀적으로 호출한다.
                    if (map[nx, ny] == 1 && !visited[nx, ny])
                    {
                        //재귀적으로 DFS를 호출하여 단지의 크기를 구한다.
                        DFS(nx, ny, ref count);
                    }
                }
            }
        }
    }
}
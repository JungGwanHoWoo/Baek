
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            // 반복할 횟수 T
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                // 값을 받아옴
                string[] s = Console.ReadLine().Split();
                // 층수 H
                int H = int.Parse(s[0]);
                // N 번째 손님
                int N = int.Parse(s[2]);
                // 방 갯수는 중요하지않다 제일 앞에서 부터 방이 나가기 때문에 결국 경우의 수는 
                // 알맞게 작성되 있고 오류 추출 코드 또한 조건에 걸려있지않다

                //층수는 경우의 수에 호텔의 층수를 나누면 알 수 있다.
                //경우에 수 마다 층수는 1층씩 빠져 나갈 것이기 때문에 나머지 값을 대입하면 그다음에 제공될
                //층수는 N의 수 크기만큼 빠져 나간다
                // 층수가 3층일 경우에  5번째 경우의 수 일때 5 % 3 = 2 , 1 2 3 -> 4 5 2층이 되는것과 같다
                //만약에 0으로 나눠질 경우 층수와 경우의 수가 같은것이기 때문에 호텔에 최대 층수를 부여하면 된다
                int floor = N % H;
                // 방번호같은 경우에도 N / H + 1의 공식을 이용하면 된다.
                // 5 / 3 의경우 1의 값에 1이 더해져 2의값이 되는데
                // 1호실의 층수 전채를 한번 반복후 돌아왔기 때문에 2번째의 호실이 제공되는것이다
                // 번외로 5 / 5 = 1일경우 502가 되는 경우에 수를 방지하기위해
                // 추가 조건을 걸어 N % H의 값이 0일경우 호수의 번호를 -1 을 해야한다
                int room = N / H + 1;

                if (N % H == 0){
                    floor = H;
                    room --;
                }
                //층수가 10층이 넘어갈경우 제공되는 형식에 맞추기 위하여 0을 추가로 삽입하여 1003호 같이 제공될수 있도록 하여야하기에
                // 이러한 조건문을 건다
                Console.Write(floor);
                if(room < 10)
                    Console.Write("0");
                System.Console.WriteLine(room);  
            }
          
        }
    }
}
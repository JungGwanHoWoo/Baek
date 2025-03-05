using System;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());
            //문장변수.Substring(시작할 위치, 자를 문장의 길이)
            //0이 시작위치이며 단어 하나만 받아오면 되니 두번째 인자는 1로 해줌
            Console.WriteLine(input.Substring(index - 1, 1));
        }
    }
}
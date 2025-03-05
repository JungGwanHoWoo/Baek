using System;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string input = "";
            string result = "";

            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                //문자열.Substring(문자 자를 시작점, 시작점부터 추출할 문자길이)
                result = input.Substring(0, 1) + input.Substring(input.Length - 1, 1);
                Console.WriteLine(result);
            }
        }
    }
}
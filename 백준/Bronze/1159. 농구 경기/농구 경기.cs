using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] s = new string[n]; // 배열 크기 지정

        for (int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();
        }

        // 첫 글자로 그룹화하고 5명 이상인 그룹만 필터링
        var result = s
            .GroupBy(x => x[0]) // 첫 글자로 그룹화
            .Where(group => group.Count() >= 5) // 5명 이상인 그룹만 필터링
            .Select(group => group.Key) // 첫 글자만 선택
            .OrderBy(c => c) // 알파벳 순 정렬 (선택사항)
            .ToList();

        // 결과 출력
        if (result.Count > 0)
        {
            Console.WriteLine(string.Join("", result)); // 연속된 문자열로 출력
        }
        else
        {
            Console.WriteLine("PREDAJA"); // 조건에 맞는 글자가 없을 경우
        }           
    }
}

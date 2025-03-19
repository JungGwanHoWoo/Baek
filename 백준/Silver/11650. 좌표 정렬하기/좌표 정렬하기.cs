using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        (int x, int y)[] points = new (int, int)[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            points[i] = (int.Parse(input[0]), int.Parse(input[1]));
        }

        // 좌표 정렬: x 오름차순, x 같으면 y 오름차순
        Array.Sort(points, (a, b) => a.x == b.x ? a.y.CompareTo(b.y) : a.x.CompareTo(b.x));

        foreach (var point in points)
        {
            sw.WriteLine($"{point.x} {point.y}");
        }

        sw.Flush();
    }
}

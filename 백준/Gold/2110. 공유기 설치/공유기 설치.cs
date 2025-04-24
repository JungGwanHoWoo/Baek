using System;
using System.Linq;

class Program
{
    static int[] houses;

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int c = int.Parse(input[1]);

        houses = new int[n];
        for (int i = 0; i < n; i++)
        {
            houses[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(houses);

        int low = 1;
        int high = houses[n - 1] - houses[0];
        int result = 0;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (CanInstall(mid, c))
            {
                result = mid;
                low = mid + 1; // 거리 더 넓혀보기
            }
            else
            {
                high = mid - 1; // 거리 좁히기
            }
        }

        Console.WriteLine(result);
    }

    static bool CanInstall(int distance, int routers)
    {
        int count = 1;
        int lastInstalled = houses[0];

        for (int i = 1; i < houses.Length; i++)
        {
            if (houses[i] - lastInstalled >= distance)
            {
                count++;
                lastInstalled = houses[i];
            }
        }

        return count >= routers;
    }
}

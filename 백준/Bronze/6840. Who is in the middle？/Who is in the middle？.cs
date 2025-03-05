using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[3];
        for (int i = 0; i<3; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(num);
        Console.WriteLine(num[1]);       
    }
}

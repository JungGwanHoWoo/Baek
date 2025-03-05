using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());

        string[] s  = Console.ReadLine().Split();
        int w = int.Parse(s[0]);
        int v = int.Parse(s[1]);

        int result = (A <= w / v) ? 1 : 0;
        System.Console.WriteLine(result);
           
    }
}

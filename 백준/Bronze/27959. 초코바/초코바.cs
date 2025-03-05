using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);

        string result = 100*N >= M ? "Yes" : "No";
        System.Console.WriteLine(result);
    
    }
}

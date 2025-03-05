using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int result = s.Contains("7") ? (int.Parse(s) % 7 == 0 ? 3 : 2) : (int.Parse(s) % 7 == 0 ? 1 : 0);
        System.Console.WriteLine(result);
       
    }
}

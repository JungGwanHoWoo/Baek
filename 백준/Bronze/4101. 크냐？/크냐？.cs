using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] s = Console.ReadLine().Split();
            int num1 = int.Parse(s[0]);
            int num2 = int.Parse(s[1]);

            if (num1 == 0 && num2 == 0) 
                return;
            string result = num1 > num2 ? "Yes" : "No";
            System.Console.WriteLine(result);
        }          
    }
}

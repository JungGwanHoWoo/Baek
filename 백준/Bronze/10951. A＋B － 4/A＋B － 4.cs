
using System;
using System.Runtime.Intrinsics.Arm;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {          

            while(true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] s = input.Split(" ");
                int s1 = int.Parse(s[0]);
                int s2 = int.Parse(s[1]);
                System.Console.WriteLine(s1 + s2);
            }
          
        }
    }
}
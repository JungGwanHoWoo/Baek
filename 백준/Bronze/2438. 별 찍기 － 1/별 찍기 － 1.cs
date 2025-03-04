
using System;
using System.Runtime.Intrinsics.Arm;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {          
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }        
        }
    }
}
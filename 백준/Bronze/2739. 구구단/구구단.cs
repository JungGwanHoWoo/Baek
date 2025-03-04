
using System;
using System.Runtime.Intrinsics.Arm;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {          
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                System.Console.WriteLine($"{num} * {i} = {i*num}");
            }
        
        }
    }
}
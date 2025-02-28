
using System;
using System.Runtime.Intrinsics.Arm;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b, c;

            for (int i = 0; i < a; i++)
            {

                string s = Console.ReadLine();
                string[] s1 = s.Split(" ");
                string[] s2 = s.Split(" ");

                b = int.Parse(s1[0]);
                c = int.Parse(s2[1]);
                System.Console.WriteLine(b + c);
            }




            // Console.WriteLine(result);           
        }
    }
}
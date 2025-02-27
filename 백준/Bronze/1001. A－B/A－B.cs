using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
    
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");

            a = int.Parse(sl[0]);
            b = int.Parse(sl[1]);
    
            Console.WriteLine (a - b);
        }
    }
}
using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, b, c;
    
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");

            a = long.Parse(sl[0]);
            b = long.Parse(sl[1]);
            c = long.Parse(sl[2]);

            
            Console.WriteLine(a + b + c);           
        }
    }
}
using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
    
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");

            a = double.Parse(sl[0]);
            b = double.Parse(sl[1]);

            
            Console.WriteLine((a / b).ToString("F9"));           
        }
    }
}
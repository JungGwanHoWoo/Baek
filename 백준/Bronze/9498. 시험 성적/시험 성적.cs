using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
           int a;
    
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");

            a = int.Parse(sl[0]);         

            Console.WriteLine(a >= 90 ?  "A" :  (a >= 80 ? "B" : (a >= 70 ? "C" : (a >= 60 ? "D" : "F") )  ));           
        }
    }
}
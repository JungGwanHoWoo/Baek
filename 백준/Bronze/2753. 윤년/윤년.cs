using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, result;
    
            string s1 = Console.ReadLine();                   

            a = int.Parse(s1);         

            result = a % 4 == 0 ? (a % 100 == 0 ? (a % 400 == 0 ? 1 : 0) : 1 ) :  0;
                    

            System.Console.WriteLine(result);           
        }
    }
}
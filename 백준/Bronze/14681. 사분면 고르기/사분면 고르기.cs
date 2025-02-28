using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b, result;
    
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            

            a = int.Parse(s1);         
            b = int.Parse(s2); 

            if (a > 0 && b > 0)
                result = 1;
            else if (a < 0 && b < 0) 
                result = 3;
            else if (a > 0 && b < 0)
                result = 4;
            else
                result = 2;
                    

            System.Console.WriteLine(result);           
        }
    }
}
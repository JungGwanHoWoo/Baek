using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
           long a, b, result;
    
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");
            string[] s2 = s.Split(" ");

            a = long.Parse(sl[0]);         
            b = long.Parse(s2[1]); 

            result = (a > b ?  a - b : b - a );
            
                    

            Console.WriteLine(result);           
        }
    }
}
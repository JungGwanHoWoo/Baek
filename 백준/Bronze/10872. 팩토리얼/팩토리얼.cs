using System;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            // long  result;
            int result =1;
            int a = int.Parse(Console.ReadLine());
            

            

            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }

            System.Console.WriteLine(result);
            
                    

            // Console.WriteLine(result);           
        }
    }
}
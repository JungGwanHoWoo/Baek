
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int F = int.Parse(Console.ReadLine());

            int num = (N / 100) * 100;

            for (int i = 0; i < 100; i++)
            {
                if((num + i) % F == 0)
                {
                    System.Console.WriteLine(i.ToString("D2"));
                    break;
                }
            }
     
        }
    }
}

using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                int num = 1;
                for(int j = 0; j < b; j++)
                    num=(num*a)%10;
                if(num==0) num=10;
                Console.WriteLine(num);
            }        
        }
    }
}
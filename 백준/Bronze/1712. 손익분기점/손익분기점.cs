
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = Console.ReadLine().Split();

            long s1 = long.Parse(s[0]);
            long s2 = long.Parse(s[1]);
            long s3 = long.Parse(s[2]);

            if (s2 >= s3)
            {
                Console.WriteLine(-1);
                return;
            }
            else
            {
                if (s1 /(s3 - s2) < 0)
                {
                    System.Console.WriteLine(-1);
                }
                else
                {
                    System.Console.WriteLine(s1 / (s3 - s2) + 1);
                }
            }        
        }
    }
}
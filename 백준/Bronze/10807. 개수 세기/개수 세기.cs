
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = int.Parse(Console.ReadLine());
            string[] s2 = Console.ReadLine().Split();
            int s3 = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < s1; i++)
            {
                if (int.Parse(s2[i]) == s3)
                {
                    result += 1;
                }
            }

            System.Console.WriteLine(result);       
        }
    }
}
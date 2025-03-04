
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            int[,] a = new int[n, m];
            int[,] b = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] s2 = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(s2[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                string[] s2 = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = int.Parse(s2[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + b[i,j] + " ");
                }
                System.Console.WriteLine();
            }        
        }
    }
}
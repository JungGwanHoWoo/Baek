
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            string[] s1 = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            for(int i = 0; i < int.Parse(s[0]); i++)
            {
                if(int.Parse(s1[i]) < int.Parse(s[1]))
                {
                    result.Append(s1[i] + " ");
                }
            }

            System.Console.WriteLine(result.ToString());         
        }
    }
}
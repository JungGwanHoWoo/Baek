using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = Console.ReadLine().Split();

            int s1 = int.Parse(s[0]);
            int s2 = int.Parse(s[1]);
            int s3 = int.Parse(s[2]);
            int s4 = int.Parse(s[3]);
            int s5 = int.Parse(s[4]);

            int result = ((s1*s1) + (s2*s2) + (s3*s3) + (s4*s4) + (s5*s5))%10;
            System.Console.WriteLine(result);
      
        }
    }
}
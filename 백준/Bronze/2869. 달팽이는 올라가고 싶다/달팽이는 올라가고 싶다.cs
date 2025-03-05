
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = Console.ReadLine().Split();

            double s1 = double.Parse(s[0]);
            double s2 = double.Parse(s[1]);
            double s3 = double.Parse(s[2]);

            double i = 1;
            i += Math.Ceiling((s3 -s1) / (s1-s2));
            System.Console.WriteLine((int)i);
       
        }
    }
}
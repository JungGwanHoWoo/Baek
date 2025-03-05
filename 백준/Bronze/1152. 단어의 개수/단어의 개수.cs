
using System;
using System.Text;

namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(" ");
            int count = 0;
            foreach (var item in s)
            {
                if (item != "")
                    count++;
            }
            System.Console.WriteLine(count);
      
        }
    }
}
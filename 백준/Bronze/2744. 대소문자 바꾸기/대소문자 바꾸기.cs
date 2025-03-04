
using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = Console.ReadLine();
            
            var result = s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
            string result2 = new string(result.ToArray());

            System.Console.WriteLine(result2);
       
        }
    }
}

using System;
using System.Text;
namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numArray = Enumerable.Range(1, 30).ToList();
            for (int i = 0; i <28; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numArray.Remove(num);
            }
            foreach (int num in numArray)
            {
                System.Console.WriteLine(num);
            }     
        }
    }
}
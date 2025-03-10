using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());  // 명령 개수 입력
            Stack<int> stack = new Stack<int>();  
            
            for (int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();

                switch (int.Parse(input[0]))
                {             
                    case 1:
                        int num = int.Parse(input[1]);
                        stack.Push(num);
                        break;

                    case 2:
                        sb.AppendLine(stack.Count > 0 ? stack.Pop().ToString() : "-1");
                        break;
                    case 3:
                        sb.AppendLine(stack.Count.ToString());
                        break;

                    case 4:
                        sb.AppendLine(stack.Count == 0 ? "1" : "0");
                        break;
                    case 5:
                        sb.AppendLine(stack.Count > 0 ? stack.Peek().ToString() : "-1");
                        break;                 
                }
            }

            sw.Write(sb.ToString());
            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}

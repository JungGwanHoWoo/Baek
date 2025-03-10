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
            Queue<int> queue = new Queue<int>();  
            int last = 0;  // 마지막으로 추가된 값 저장

            for (int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();

                switch (input[0])
                {             
                    case "push":
                        int num = int.Parse(input[1]);
                        queue.Enqueue(num);
                        last = num;
                        break;

                    case "pop":
                        sb.AppendLine(queue.Count > 0 ? queue.Dequeue().ToString() : "-1");
                        break;

                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;

                    case "empty":
                        sb.AppendLine(queue.Count == 0 ? "1" : "0");
                        break;

                    case "front":
                        sb.AppendLine(queue.Count > 0 ? queue.Peek().ToString() : "-1");
                        break;

                    case "back":
                        sb.AppendLine(queue.Count > 0 ? last.ToString() : "-1");
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

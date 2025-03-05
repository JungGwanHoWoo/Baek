using System;
using System.Text;

namespace 백준
{
    public struct Data
    {
        public string Value { get; set; }
        public int Multiplier { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            List<(int,int)> white = new List<(int,int)>();

            int start;
            for(int i = 0;  i < 8; i++)
            {
                start = (i == 0 || i % 2 == 0) ? 0 : 1;

                for (int j = start; j < 8; j +=2)
                    white.Add((i,j));
            }

            int[,] inputMap = new int [8,8];
            for(int i = 0; i < 8; i++)
            {
                string str = reader.ReadLine();
                for(int j = 0; j<8; j++) 
                {
                    if(str[j] =='F')
                        inputMap[i,j] = 1;
                    else
                        inputMap[i,j] = 0;
                }
            }

            int count = 0;
            for(int i = 0; i < white.Count; i++)
            {
                if(inputMap[white[i].Item1, white[i].Item2] == 1)
                    count++;
            }

            writer.WriteLine(count);

            writer.Close();
            reader.Close(); 
        }
    }
}
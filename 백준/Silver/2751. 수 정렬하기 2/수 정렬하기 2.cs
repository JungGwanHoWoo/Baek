using System;
using System.IO;
using System.Text;

namespace 백준
{
    class Program
    {
        static Random rand = new Random();

        static void QuickSort(int[] arr, int left, int right)
        {
            while (left < right)
            {
                if (right - left < 16)
                {
                    InsertionSort(arr, left, right);
                    return;
                }

                int pivotIndex = Partition(arr, left, right);
                if (pivotIndex - left < right - pivotIndex)
                {
                    QuickSort(arr, left, pivotIndex - 1);
                    left = pivotIndex + 1;
                }
                else
                {
                    QuickSort(arr, pivotIndex + 1, right);
                    right = pivotIndex - 1;
                }
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivotIndex = left + rand.Next(right - left + 1);
            int pivot = arr[pivotIndex];
            (arr[pivotIndex], arr[right]) = (arr[right], arr[pivotIndex]);

            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
            return i + 1;
        }

        static void InsertionSort(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= left && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput(), bufferSize: 1024 * 64);
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1024 * 64);
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = int.Parse(sr.ReadLine());

            QuickSort(array, 0, array.Length - 1);

            for (int i = 0; i < n; i++)
                sb.Append(array[i]).Append('\n');

            sw.Write(sb.ToString());
            sw.Flush();
            sr.Close();
            sw.Close();
        }
    }
}

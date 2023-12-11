using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            double[] array = new double[10] { 0, 10, -2, 4, -5, 6, 7, 8, 0, -10 };
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    double x = array[i];
                    array[i] = Math.Pow(array[i],2);
                }
                if (array[i] > 0)
                {
                    array[i] = array[i] / 2;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
              
        }

        private static void ex2()
        {
            int[] array = new int[10] { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = array.Max();
            int min = array.Min();
            int indexmax = Array.IndexOf(array, max);
            int indexmin = Array.IndexOf(array, min);
            float sum = 0;
            float count = 0;
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                count++;
                sum += array[i];
            }
            Console.WriteLine(sum);
            float arifm = sum / count;
            Console.WriteLine(arifm);
        }

        private static void ex1()
        {
            int[] array = new int[10] { 1, 2, -3, 4, 5, 7, 6, -100, -5, -2, };
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            int proizv = 1;
            foreach (int i in array)
            {
                if (i < 0)
                {
                    list.Add(i);
                }
                if (i > 0)
                {
                    list2.Add(i);
                }
            }
            int indexFirst = Array.IndexOf(array, list[0]);
            int indexLast = Array.IndexOf(array, list2[list2.Count - 1]);
            for (int i = indexFirst + 1; i < indexLast; i++)
            {
                proizv = proizv * array[i];
            }
            Console.WriteLine(proizv);
        }
    }
}

using System;
using static System.Console;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            var rand = new Random();
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    arr[i, j] = rand.Next(0, 15);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Write(arr[i, j] + "|");
                }
                WriteLine(" ");
            }
            int k = 0,summ=0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    summ = summ + arr[i, j];
                    k++;
                }
            }
            WriteLine($"среднее арифметическое = {summ * 1.0 / k}");
            int min = arr[0, 0], max = arr[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
            }
            WriteLine("минимальное значение:" + min);
            WriteLine("максимальное значение" + max);
        }
    }
}

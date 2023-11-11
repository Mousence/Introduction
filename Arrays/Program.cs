//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 200);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
            Console.WriteLine($"Среднее-арифметическое массива: {arr.Average()}");
            Console.WriteLine($"Минимальное значение массива: {arr.Min()}");
            Console.WriteLine($"Масксимальное значение массива: {arr.Max()}");
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); 
#endif
#if ARRAYS_2
            Random rand = new Random();

            Console.Write("Введите кол-во строк массива: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов массива: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];
            Console.WriteLine($"Количество измерений массива: {arr.Rank}");
            Console.WriteLine($"Количество строк массива: {arr.GetLength(0)}");
            Console.WriteLine($"Количество столбцов массива: {arr.GetLength(1)}");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = rand.Next(100);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write((arr[i, j] + "\t"));
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма элементов массива: {arr.Cast<int>().Sum()}");
            Console.WriteLine($"Среднее-арифметическое массива: {arr.Cast<int>().Average()}");
            Console.WriteLine($"Минимальное значение массива: {arr.Cast<int>().Min()}");
            Console.WriteLine($"Масксимальное значение массива: {arr.Cast<int>().Max()}"); 
#endif
            int[][] arr = new int[][] {
            new int[] { 0, 1, 1, 2 },
            new int[] { 3, 5, 8 },
            new int[] { 13, 21 },
            new int[] { 34, 55, 89}
            };

            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }


            int min = arr[0][0], max = arr[0][0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (max < arr[i][j])
                        max = arr[i][j];
                    if(min > arr[i][j])
                        min = arr[i][j];
                }
            }
            Console.WriteLine($" min = {min}, max = {max}");

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i][j];
                }
            }

            Console.WriteLine($" sum = {sum}");
        }
    }
}

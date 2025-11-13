using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_LAB4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1\nФормирование одномерного и двумерного массива");
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Random rand = new Random();

            double[] oneD = new double[n];
            double[,] twoD = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                int k = rand.Next(1, 10);
                oneD[i] = Math.Pow(5, k) / Math.Sqrt(n * (n + 1));
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int k = rand.Next(1, 10);
                    twoD[i, j] = Math.Pow(5, k) / Math.Sqrt(n * (n + 1));
                }
            }

            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < n; i++) Console.Write(oneD[i].ToString("F2") + " ");
            Console.WriteLine("\nДвумерный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(twoD[i, j].ToString("F2") + " ");
                Console.WriteLine();
            }
            Console.WriteLine("\nЗадание 2\nСреднее арифметическое элементов массивов A и B");
            Console.Write("Введите размер массивов: ");
            int size = int.Parse(Console.ReadLine());
            int[] A = new int[size];
            int[] B = new int[size];

            for (int i = 0; i < size; i++)
            {
                A[i] = rand.Next(1, 100);
                B[i] = rand.Next(1, 100);
            }

            double avgA = 0, avgB = 0;
            for (int i = 0; i < size; i++)
            {
                avgA += A[i];
                avgB += B[i];
            }
            avgA /= size;
            avgB /= size;

            Console.WriteLine("Массив A: " + string.Join(" ", A));
            Console.WriteLine("Массив B: " + string.Join(" ", B));
            Console.WriteLine("Среднее A = " + avgA.ToString("F2"));
            Console.WriteLine("Среднее B = " + avgB.ToString("F2"));
            Console.WriteLine("\nЗадание 3\nСумма элементов на главной диагонали");
            Console.Write("Введите размер квадратного массива n: ");
            int sizeD = int.Parse(Console.ReadLine());
            int[,] arr = new int[sizeD, sizeD];
            int diagSum = 0;

            for (int i = 0; i < sizeD; i++)
            {
                for (int j = 0; j < sizeD; j++)
                {
                    arr[i, j] = rand.Next(1, 10);
                    if (i == j) diagSum += arr[i, j];
                }
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < sizeD; i++)
            {
                for (int j = 0; j < sizeD; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Сумма элементов на главной диагонали = " + diagSum);
            Console.WriteLine("\nЗадание 4\nБыстрая сортировка (упрощённая версия)");

            int[] arrSort = new int[10];
            for (int i = 0; i < arrSort.Length; i++)
                arrSort[i] = rand.Next(0, 100);

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(" ", arrSort));

            QuickSort(arrSort, 0, arrSort.Length - 1);

            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine(string.Join(" ", arrSort));

            Console.WriteLine("\nГотово!");
        }

        // Упрощённая реализация быстрой сортировки без Stack<>
        static void QuickSort(int[] array, int left, int right)
        {
            int i = left, j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
    }
}

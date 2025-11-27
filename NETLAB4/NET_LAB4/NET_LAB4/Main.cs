using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace NET_LAB4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1 - Формирование массивов");
                Console.WriteLine("2 - Среднеарифметические двух массивов");
                Console.WriteLine("3 - Сумма элементов главной диагонали");
                Console.WriteLine("4 - Быстрая сортировка массива");
                Console.WriteLine("0 - Выход");
                Console.Write("Введите номер: ");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }

        static void Task1()
        {
            try
            {
                Console.Write("Введите значение n (длина массива): ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите значение m (количество столбцов): ");
                int m = int.Parse(Console.ReadLine());
                if (n <= 0 || m <= 0)
                {
                    Console.WriteLine("Значения n и m должны быть положительными.");
                    return;
                }

                Random rand = new Random();

                double[] array1D = new double[n];
                double[,] array2D = new double[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int k = rand.Next(1, 10);
                        Console.Write("\nСлучайное значение K: {0} ", k);
                        double value = Math.Pow(5, k) / Math.Sqrt((i+1) * ((i+1) + 1));

                        array1D[i] = value;
                        array2D[i, j] = value;
                    }
                }

                Console.WriteLine("\nОдномерный массив:");
                foreach (var item in array1D)
                {
                    Console.WriteLine($"{item:F1}");
                }

                Console.WriteLine("Двумерный массив:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{array2D[i, j]:F1} ");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }

        static void Task2()
        {
            int sizeA, sizeB;

            Console.Write("Введите размер массива A: ");
            if (!int.TryParse(Console.ReadLine(), out sizeA) || sizeA <= 0)
            {
                Console.WriteLine("Некорректный ввод размера A.");
                return;
            }

            Console.Write("Введите размер массива B: ");
            if (!int.TryParse(Console.ReadLine(), out sizeB) || sizeB <= 0)
            {
                Console.WriteLine("Некорректный ввод размера B.");
                return;
            }

            //Рандоммм
            double[] A = new double[sizeA];
            double[] B = new double[sizeB];
            Random rand = new Random();

            for (int i = 0; i < sizeA; i++)
            {
                A[i] = rand.NextDouble() * 100;
            }
            for (int i = 0; i < sizeB; i++)
            {
                B[i] = rand.NextDouble() * 100;
            }

            double sumA = 0;
            foreach (var item in A)
            {
                sumA += item;
            }
            double meanA = sumA / A.Length;

            double sumB = 0;
            foreach (var item in B)
            {
                sumB += item;
            }
            double meanB = sumB / B.Length;

            Console.WriteLine("Массив A:");
            foreach (var item in A)
            {
                Console.Write($"{item:F2} ");
            }
            Console.WriteLine($"\nСреднее A: {meanA:F1}");

            Console.WriteLine("Массив B:");
            foreach (var item in B)
            {
                Console.Write($"{item:F1} ");
            }
            Console.WriteLine($"\nСреднее B: {meanB:F1}");
        }

        static void Task3()
        {
            try
            {
                Console.Write("Введите размер массива n: ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Размер массива доджен быть положительным числом.");
                    return; 
                }

                double[,] A = new double[n, n];
                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = rand.NextDouble() * 100;
                    }
                }

                Console.WriteLine("Массив A:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{A[i, j]:F1} ");
                    }
                    Console.WriteLine();
                }

                double sumDiagonal = 0;
                for (int i = 0; i < n; i++)
                {
                    sumDiagonal += A[i, i];
                }
                Console.WriteLine($"Сумма элементов главной диагонали: {sumDiagonal:F1}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }

        static void Task4()
        {
            try
            {
                Console.Write("Введите размер массива для сортировки: ");
                int size = int.Parse(Console.ReadLine());
                if (size <= 0)
                {
                    Console.WriteLine("Размер должен быть положительным.");
                    return;
                }

                double[] array = new double[size];
                Random rand = new Random();

                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.NextDouble() * 100;
                }

                Console.WriteLine("Массив до сортировки:");
                foreach (var item in array)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine();

                QuickSort(array, 0, array.Length - 1);

                Console.WriteLine("Массив после сортировки:");
                foreach (var item in array)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }

        static void QuickSort(double[] arr, int left, int right)
        {
            if (left >= right)
                return;

            double pivot = arr[(left + right) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (arr[i] < pivot) 
                    i++;
                while (arr[j] > pivot) 
                    j--;
                if (i <= j)
                {
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j) 
                QuickSort(arr, left, j);
            if (i < right) 
                QuickSort(arr, i, right);
        }
    }

}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Первая размерность массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массива: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double[,] matrix= new double[rows,colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= (new Random().NextDouble() + new Random().Next(10, 100));
//         Console.Write($"{matrix[i,j]:F2}  ");
//     }
//     Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// // Заполняем массив рандомными числами от 10 до 99

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10, 99);
//         }
//     }
// }

// // Выводим массив на экран

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите индекс строки:: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите индекс столбца: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[5, 9];
// Console.WriteLine();
// FillArray(array);
// PrintArray(array);

// if (rows < array.GetLength(0) && colomns < array.GetLength(1)) 
// {
//     Console.WriteLine(array[rows, colomns]);
// }
// else 
// {
//     Console.WriteLine("Элемента с данным значением в массиве нет");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Первая размерность массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массива: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix= new int[rows,colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(10,99);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double average = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         average = (average + matrix[i, j]);
//     }
//     average = average / rows;
//     Console.Write($"{average:F2};  ");
// }




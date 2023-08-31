﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Первая размерность массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массива: ");
// int coloms = Convert.ToInt32(Console.ReadLine());

// int[,] matrix= new int[rows,coloms];
 
// void CreateArray(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             array[i,j] = new Random().Next(0,40); 
//         } 
//     } 
// } 
 
// void PrintArray(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             Console.Write(array[i,j] + " "); 
//         } 
//         Console.WriteLine(); 
//     } 
// } 


// void SortArray(int[,] array) 
// { 
//   for (int i = 0; i < array.GetLength(0); i++) 
//   { 
//     for (int j = 0; j < array.GetLength(1); j++) 
//     { 
//       for (int k = 0; k < array.GetLength(1)-1;k++) 
//       { 
//         if (array[i, k] < array[i, k + 1]) 
//         { 
//           int temp = array[i, k + 1]; 
//           array[i, k + 1] = array[i, k]; 
//           array[i, k] = temp; 
//         } 
//       } 
//     } 
//   } 
// } 
// CreateArray(matrix); 
// PrintArray(matrix); 
// SortArray(matrix); 
// System.Console.WriteLine(); 
// PrintArray(matrix);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Первая размерность массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массива: ");
// int coloms = Convert.ToInt32(Console.ReadLine());

// int[,] matrix= new int[rows,coloms];
 
 
// void CreateArray(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             array[i,j] = new Random().Next(0,40); 
//         } 
//     } 
// } 
 
// void PrintArray(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             Console.Write(array[i,j] + " "); 
//         } 
//         Console.WriteLine(); 
//     } 
// } 


// void MinSum(int[,]array) 
// { 
//     int minRow = 0; 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         int sum = 0; 
//         int min = int.MaxValue; 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             sum += array[i,j]; 
//         } 
//         Console.WriteLine($"Сумма строки {i + 1} = {sum}"); 
//         if (sum < min) 
//         { 
//             minRow = i; 
//         } 
 
//     } 
//     Console.WriteLine($"Строка с наименьшей суммой: {minRow}"); 
// } 
 
// CreateArray(matrix); 
// PrintArray(matrix); 
// MinSum(matrix);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Первая размерность первого массива: ");
int rowsOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая размерность первого массива: ");
int colomsOne = Convert.ToInt32(Console.ReadLine());

int[,] matrixOne = new int[rowsOne,colomsOne];

Console.WriteLine("Первая размерность второго массива: ");
int rowsTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая размерность второго массива: ");
int colomsTwo = Convert.ToInt32(Console.ReadLine());

int[,] matrixTwo = new int[rowsTwo,colomsTwo];

if (colomsOne == rowsTwo)
{

int[,] matrixThree = new int[rowsTwo, colomsOne];

void CreateArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i,j] = new Random().Next(0,10); 
        } 
    } 
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + " "); 
        } 
        Console.WriteLine(); 
    } 
} 

void MatrixMulty(int[,] firstArray, int[,] secondArray, int[,] finalArray)
{ 
    for (int i = 0; i < finalArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < finalArray.GetLength(1); j++) 
        { 
            int sum = 0;
            for (int k = 0; k < secondArray.GetLength(1); k++)
                {
                    sum += firstArray[i, k] * secondArray[k, j];
                }
            finalArray[i, j] = sum;
        } 
    } 
}
CreateArray(matrixOne);
PrintArray(matrixOne);
Console.WriteLine();
CreateArray(matrixTwo);
PrintArray(matrixTwo);
Console.WriteLine();
MatrixMulty(matrixOne, matrixTwo, matrixThree);
PrintArray(matrixThree);
}
else 
{
    Console.WriteLine("Введите размерности верно! Количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы.");
}
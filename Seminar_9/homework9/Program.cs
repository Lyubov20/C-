// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// if (num > 0)
// {
//     Console.WriteLine(PrintNumbers(num));

//     string PrintNumbers(int start)
//     {
//         if(start==1)
//         {
//             return start.ToString();
//         }
//     return (start+ " "+ PrintNumbers(start-1));
//     }
// }
// else
// {
//     Console.WriteLine("Введите натуральное число!");
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers(int numberOne, int numberTwo)
// {
//     if(numberOne == numberTwo)
//     {
//         return numberOne;
//     }
//     if(numberOne < numberTwo)
//     {
//         return numberTwo + SumNumbers(numberOne, numberTwo - 1);
//     }
//     else
//     {
//         return numberTwo + SumNumbers(numberOne, numberTwo + 1);
//     }
// }

// System.Console.Write("Введите значение числа M: ");
// int m = int.Parse(Console.ReadLine());
// System.Console.Write("Введите значение числа N: ");
// int n = int.Parse(Console.ReadLine());
// System.Console.Write($"M = {m}; N = {n} -> {SumNumbers(m, n)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akk(int numOne, int numTwo)
// {
//     if (numOne == 0) return numTwo + 1;
//     if (numOne != 0 && numTwo == 0) return Akk(numOne - 1, 1);
//     if (numOne > 0 && numTwo > 0) return Akk(numOne - 1, Akk(numOne, numTwo - 1));
//     return Akk(numOne,numTwo);
// }
// bool error = true;
// int m = 0;
// int n = 0;
// while(error)
// {
//     System.Console.Write("Введите первое число: ");
//     m = int.Parse(Console.ReadLine());
//     System.Console.Write("Введите второе число: ");
//     n = int.Parse(Console.ReadLine());
//     if(m < 0 || n < 0)
//     {
//         System.Console.WriteLine("Ошибка! Оба числа должны быть положительными!");
//     }
//     else
//     {
//         error = false;
//     }
// }

// System.Console.Write($"m = {m}, n = {n} - > A(m,n) = {Akk(m, n)}");
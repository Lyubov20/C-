// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первый способ

// Console.WriteLine("Введите пятизначное число: ");
// int  num = Convert.ToInt32(Console.ReadLine());

// int num1 = num / 10000;
// int num2 = num % 10;
// int num3 = (num / 1000) % 10;
// int num4 = (num % 100) / 10; 

// if (num1 == num2 && num3 == num4)
// {
//     Console.WriteLine("Да");
// }
// else if (num < 10000 || num > 99999)
// {
//     Console.WriteLine("Введите пятизначное число!"); 
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Второй способ

// Console.WriteLine("Введите пятизначное число: ");
// string  num = Console.ReadLine();

// int size = num.Length;

// if (size == 5)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine("Да");
//     }
//     else 
//     {
//         Console.WriteLine("Нет");   
//     }
// }
// else 
// {
//     Console.WriteLine("Введите пятизначное число!"); 
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите X1: ");
// int  X1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите Y1: ");
// int  Y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите Z1: ");
// int  Z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите X2: ");
// int  X2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите Y2: ");
// int  Y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите Z2: ");
// int  Z2 = Convert.ToInt32(Console.ReadLine());

// double s = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));

// Console.WriteLine($"Расстояние между точками равно {s}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int  num = Convert.ToInt32(Console.ReadLine());

// for (int i=1; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }

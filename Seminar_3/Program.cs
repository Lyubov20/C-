// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y = Convert.ToInt32(Console.ReadLine());

// if(X>0 && Y>0)
// {
//     Console.WriteLine("1");
// }
// else if(X<0 && Y>0)
// {
//     Console.WriteLine("2");
// }
// else if(X<0 && Y<0)
// {
//     Console.WriteLine("3");
// }
// else if(X>0 && Y<0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Точка лежит на оси");
// }


// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат
// точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int  num = Convert.ToInt32(Console.ReadLine());

// if(num == 1)
// {
//     Console.WriteLine("X>0 и Y>0");
// }
// else if(num == 2)
// {
//     Console.WriteLine("X<0 и Y>0");
// }
// else if(num == 3)
// {
//     Console.WriteLine("X<0 и Y<0");
// }
// else if(num == 4)
// {
//     Console.WriteLine("X>0 и Y<0");
// }
// else
// {
//     Console.WriteLine("Пожалуйста, введите номер четверти");
// }


// второй вариант решения данной задачи

// Console.WriteLine("Введите номер четверти: ");
// int  num = Convert.ToInt32(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     {
//         Console.WriteLine("X>0 и Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("X<0 и Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("X<0 и Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("X>0 и Y<0");
//         break;
//     }
//     default:
//     {
//        Console.WriteLine("Не подходит");
//        break; 
//     }
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 2D пространстве.
// А(3,6); В(2,1) -> 5,09
// А(7,-5); В(1,-1) -> 7,21

// Console.WriteLine("Введите X1: ");
// int  X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y1: ");
// int  Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите X2: ");
// int  X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y2: ");
// int  Y2 = Convert.ToInt32(Console.ReadLine());

// double s = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

// Console.WriteLine($"Расстояние между точками равно {s}");



// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

// Console.WriteLine("Введите число: ");
// int  num = Convert.ToInt32(Console.ReadLine());

// for (int i=0; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i, 2));
// }




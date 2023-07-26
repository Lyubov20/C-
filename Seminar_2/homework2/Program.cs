// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int num1 = num % 100;
// int num2 = num % 10;
// int result = (num1 - num2) / 10;

// Console.WriteLine($"Вторая цифра числа {num} равна {result}.");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(10,40001);
// Console.WriteLine(num);

// string numText = Convert.ToString(num);

// if (numText.Length > 2)
// {
//     Console.WriteLine($"Третья цифра числа {num} равна {numText[2]}");
// }
// else 
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int num = new Random().Next(0,11);
// Console.WriteLine(num);

// if ((num == 6) || (num == 7) )
// {
//     Console.WriteLine("Да");
// }
// else if ((num < 1) || (num > 7))
// {
//     Console.WriteLine("Это не день недели");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
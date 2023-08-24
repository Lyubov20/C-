// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1 способ (знаем, сколько чисел и без массива)

// Console.Write("Введите количество чисел: ");
// int amount = Convert.ToInt32(Console.ReadLine());
// if (amount <= 0)
// {
//     Console.WriteLine("Ошибка! Введите количество чисел!");
// }

// int count = 0;
// for (int i = 0; i < amount; i++)
// {
//     Console.Write("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 0)
//     {
//         count+=1;
//     }
// }
// Console.Write($"Количество чисел, больших нуля, равно {count}");

// 2 способ (не знаем, сколько чисел и с массивом)

// Console.Write("Введите числа через пробел: ");

// int[] ConvertStringToArray(string numbers)
// {
//     int amount = 1;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == ' ')
//         {
//             amount+=1;
//         }
//     }

//     int[] num = new int [amount];
    
//     int count = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         string res = "";

//         while (numbers[i] != ' ')
//         {
//         if(i < numbers.Length - 1)
//         {
//             res += numbers[i].ToString();
//             i++;
//         }
//         else
//         {
//             res += numbers[i].ToString();
//             break;
//         }
//         }
//         num[count] = Convert.ToInt32(res);
//         count++;
//     }
//     return num;
// }

// int[] num = ConvertStringToArray(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine($"\nКоличество элементов, больших нуля равно {sum}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());


// double x = (b2 - b1)/(k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Две прямые пересекутся в точке с координатами ({x},{y})");
// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = ""; 

// while (num > 0)
// {
//     result = num%2 + result;
//     num = num / 2;
// }
// Console.WriteLine(result);


// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
// со сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
// двух других сторон. 

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("Нет");
// }

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N=5, 0 1 1 2 3 
// Если N=3, 0 1 1 
// Если N=7, 0 1 1 2 3 5 8 

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0;
// int secondNum = 1;

// Console.WriteLine(firstNum);
// Console.WriteLine(secondNum);

// for (int i = 2; i < num; i++)
// {
//     int nextNum = firstNum + secondNum;
//     Console.WriteLine(nextNum);
//     firstNum = secondNum;
//     secondNum = nextNum;
// }

// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]

// int[] array = new int[] {1, 2, 3, 4, 5};

// void ReversArray()
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 -i];
//         array[array.Length - 1 -i] = temp;
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        Console.Write(array[i]+" ");
//     }
// }
// ReversArray();
// PrintArray();

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

// int[] array = new int[] {1, 2, 3, 4, 5};
// int[] copyArray = new int[array.Length];
 
// void CopyArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         copyArray[i] = array[i];
//     }
// }
// void PrintCopyArray()
// {
//     for (int i = 0; i < copyArray.Length; i++)
//     {
//        Console.Write(copyArray[i]+" ");
//     }
// }
// CopyArray();
// PrintCopyArray();


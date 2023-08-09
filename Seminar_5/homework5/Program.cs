// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());


// int[] array = new int [num];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + " ");
// }

// int result = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] % 2 == 0)
//     {
//         result++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine(result);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Первый способ

// Console.Write("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());


// int[] array = new int [num];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-40, 41);
//     Console.Write(array[i] + " ");
// }

// int sum = 0;
// for (int j = 1; j < array.Length; j+=2)
// {
//     sum+=array[j];
// }
// Console.WriteLine();
// Console.WriteLine("Сумма чисел, стоящих на нечетных позициях равна " + sum);

//Второй способ

// Console.Write("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());


// int[] array = new int [num];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-40, 41);
//     Console.Write(array[i] + " ");
// }

// int sum = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     if (j % 2 != 0)
//     {
//         sum+=array[j];
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Сумма чисел, стоящих на нечетных позициях равна " + sum);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());


double[] array = new double [num];
for (int i = 0; i < num; i++)
{
    // array[i] = Convert.ToDouble(new Random().Next(-100,100)) / 100;
    // Console.Write(array[i] + " ");
    array[i] = new Random().NextDouble();
    Console.Write($"{array[i]:F2}  ");
}

double min = array[0];
double max = array[0];
// for (int j = 1; j < array.Length; j++)
// {
//     if (max < array[j])  
//     {
//         max = array[j];
//     }
//     if (min > array[j])
//     {
//         min = array[j];
//     }
//     j++;
// }
int j = 1;
while (j < array.Length)
{
if (max < array[j])
max = array[j];
if (min > array[j])
min = array[j];
j = j + 1;
}
Console.WriteLine();
Console.WriteLine($"({max:F2}) - ({min:F2}) = {(max-min):F2}");

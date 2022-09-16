// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.

using System;

Console.Write("Введите размер массива size = ");
int size = int.Parse(Console.ReadLine()!);

int[] numbers = CreateRandomArray(size);
PrintArray(numbers);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {CountSumOddIndexNumbers(numbers)}");


int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-100, 101);
    }
    return numbers;
}


void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}


int CountSumOddIndexNumbers(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i+=2)
    {
        sum += numbers[i];
    }
    return sum;
}


// int CountSumOddIndexNumbers(int[] numbers)
// {
//     int sum = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
        
//         if (i % 2 != 0)
//         {
//             sum += numbers[i];
//         }

//     }
//         return sum;
// }
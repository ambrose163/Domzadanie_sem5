// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементами массива.

using System;

Console.Write("Введите размер массива size = ");
int size = int.Parse(Console.ReadLine()!);

double[] numbers = CreateRandomArray(size);
PrintArray(numbers);
// Console.WriteLine($"Макс элемент массива = {FindMaxNumber(numbers)}, мин = {FindMinNumber(numbers)}");
double difference = FindMaxNumber(numbers) - FindMinNumber(numbers);
Console.WriteLine($"Разница между макс и мин элементами массива = {difference}");

double[] CreateRandomArray(int size)
{
    double[] numbers = new double[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-100, 101);
    }
    
    return numbers;
}


void PrintArray(double[] numbers)
{
    foreach (double number in numbers)
        {
            Console.Write($"{number} ");
        }
    Console.WriteLine();
}


double FindMaxNumber(double[] numbers)
{
    double max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
    }
    return max;
}

double FindMinNumber(double[] numbers)
{
    double min = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];
    }
    return min;
}
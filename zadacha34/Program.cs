// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива size = ");
int size = int.Parse(Console.ReadLine()!);

int[] numbers = CreateRandomArray(size);
PrintArray(numbers);
Console.WriteLine($"Кол-во четных чисел в массиве = {CountEvenNumbers(numbers)}");

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
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


int CountEvenNumbers(int[] numbers)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
                count++;
    }

    return count;
}
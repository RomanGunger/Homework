// Урок 5. Функции и одномерные массивы

// В lowerBound, upperBound передаем промежуток для Random.Next(lowerBound, upperBound)
int[] CreateRandomIntArray(int length, int lowerBound, int upperBound)
{
    int[] array = new int[length];

    Random rnd = new Random();

    Console.WriteLine("Random int Array:");
    Console.Write("[ ");
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(lowerBound, upperBound);
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();

    return array;
}

// В lowerBound, upperBound передаем промежуток для Random.Next(lowerBound, upperBound)
double[] CreateRandomDoubleArray(int length, int lowerBound, int upperBound)
{
    double[] array = new double[length];

    Random rnd = new Random();

    Console.WriteLine("Random double Array:");
    Console.Write("[ ");
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.NextDouble() + rnd.Next(lowerBound, upperBound);
        Console.Write($"{array[i]:F2} ");
    }
    Console.Write("]");
    Console.WriteLine();

    return array;
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Можно было и без листа, чисто счетчиком сделать(просто если находим четное count++),
// но захотелось попробовать лист :) 
void ShowEvenNumbers(int[] array)
{
    System.Console.WriteLine("Задача 34");
    List<int> evenNumbers = new List<int>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) evenNumbers.Add(array[i]);
    }

    Console.WriteLine($"Number of even number in array: {evenNumbers.Count}");
    Console.WriteLine();
}

ShowEvenNumbers(CreateRandomIntArray(15, 0, 999));





// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void OddNumbersSumm(int[] array)
{
    System.Console.WriteLine("Задача 36");
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(i%2==0)
        {
            summ += array[i];
        }
    }

    Console.WriteLine($"Summ of number on the odd positions: {summ}");
    Console.WriteLine();
}

OddNumbersSumm(CreateRandomIntArray(10, 0, 9));





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


void MaxMinDifference(double[] array)
{
    System.Console.WriteLine("Задача 38");

    Array.Sort(array);
    double diff = array[array.Length - 1] - array[0];

    // Пометка для себя: округлять числа с плавающей запятой так же можно через
    // array[i]:F2 как в методе CreateRandomDoubleArray() при выводе в консоль

    Console.WriteLine($"Min: {Math.Round(array[0], 2)}");
    Console.WriteLine($"Max: {Math.Round(array[array.Length - 1], 2)}");
    Console.WriteLine($"Difference between max and min: {Math.Round(diff, 2)}");
}

MaxMinDifference(CreateRandomDoubleArray(15, 0, 100));
// Урок 6. Одномерные массивы. Продолжение

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Promt(string message)
{
    Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// int[] InputArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Promt($"Input {i + 1} number: ");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{i} ");
//     }
//     Console.Write("]");
// }

// int PositiveCount(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) count++;
//     }
//     return count;
// }

// int length = Promt("Input numbers quantity");
// int[] array = InputArray(length);
// PrintArray(array);
// Console.WriteLine($"The number of positive numbers: {PositiveCount(array)}");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void LineCrossPoint(double b1, double k1, double b2, double k2)
{
    string line1 = $"y = ({k1})x + ({b1})";
    string line2 = $"y = ({k2})x + ({b2})";

    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;
    Console.WriteLine($"(The cross point of two lines {line1} and {line2} is {Math.Round(x, 2)} : {Math.Round(y, 2)})");
}

LineCrossPoint(Promt("Input b1"),
                 Promt("Input k1"),
                  Promt("Input b2"),
                   Promt("Input k2"));





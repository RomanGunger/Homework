// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void NaturalNumbers(int N)
{
    Console.Write($"{N--} ");
    if(N > 0) NaturalNumbers(N);
}

Console.WriteLine("Задача 64. Натуральные числа");
NaturalNumbers(5);





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int NaturalNumbersSumm(int M, int N)
{
    if(M == N) return 0;
    else return NaturalNumbersSumm(M, N - 1) + N;
}

Console.WriteLine();
Console.WriteLine("Задача 66. Сумма натуральных чисел от M до N");

int M = 1;
int N = 15;
Console.WriteLine($"Сумма натуральных чисел от M до N = {NaturalNumbersSumm(M - 1,N)}");
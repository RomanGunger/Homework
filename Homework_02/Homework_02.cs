//Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Да, мы не проходили на задяниях еще Math.Abs, но я подглядел вот тут
//https://learn.microsoft.com/ru-ru/dotnet/api/system.math.abs?view=net-7.0
// чтобы избежать большого условия в проверке на трехзначность,
// ибо там же еще отрицательные трехзначные. Это не наказывается?)

int SecondDigit(int num)
{
    return (num % 100) / 10;
}

Console.WriteLine("Input a 3 digit number");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(num > 100 && num < 1000)
    Console.WriteLine(SecondDigit(num));
else Console.WriteLine("Wrong number");





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigit(int num)
// {
//     while(num > 999)
//     {
//         num /= 10;
//     }

//     return num % 10;
// }

// Console.WriteLine("Input a number");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// if(num < 100) Console.WriteLine("There is no 3rd digit");
// else Console.WriteLine(MathF.Abs(ThirdDigit(num)));





// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void CheckForWeekend(int num)
// {
//     if(num >= 6 && num <=7)
//     Console.WriteLine("WEEKEND :)");
//     else Console.WriteLine("Work - Work :(");
// }

// Console.WriteLine("Input a number");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num > 0 && num <=7) CheckForWeekend(num);
// else Console.WriteLine("Wrong number");
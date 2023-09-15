//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input a number 1");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number 2");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
//     Console.WriteLine($"Highest number is {num1}, Lowest number is {num2}");
// else if(num1 < num2)
//     Console.WriteLine($"Highest number is {num2}, Lowest number is {num1}");
// else
//      Console.WriteLine($"The numbers {num1} and {num2} are equal");





//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input a number 1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number 1");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number 1");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    if(num1 > num3)
        Console.WriteLine($"Highest number is {num1}");
    else
        Console.WriteLine($"Highest number is {num3}");
}
else
{
    if(num2 > num3)
        Console.WriteLine($"Highest number is {num2}");
    else
        Console.WriteLine($"Highest number is {num3}");
}




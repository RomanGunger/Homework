// Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void PowerOf(int A, int B)
{
    int tempA = A;
    for (int i = 0; i < B - 1; i++)
    {
        A = A * tempA;
    }

    Console.WriteLine($"{tempA} in the power of {B} equals {A}");
}

PowerOf(5 , 3);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// void NumbersSumm(int number)
// {
//     int count = 0;
//     int summ = 0;
//     while(number != 0)
//     {
//         summ += number % 10;
//         number /= 10;
//         count++;
//     }

//     Console.WriteLine($"Summ is {Math.Abs(summ)}");
// }

// NumbersSumm(13245);






// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// void PrintArray()
// {
//     int randomSize = new Random().Next(0, 9);
//     int[] randomArray = new int[randomSize];

//     Console.Write("[ ");
//     for (int i = 0; i < randomSize; i++)
//     {
//         randomArray[i] = new Random().Next(0, 99);
//         Console.Write($"{randomArray[i]} ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// PrintArray();
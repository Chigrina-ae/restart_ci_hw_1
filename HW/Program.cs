// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input two numbers");
int NumberOne = Convert.ToInt32(Console.ReadLine());
int NumberTwo = Convert.ToInt32(Console.ReadLine());

if(NumberOne > NumberTwo)
    {
        Console.WriteLine($"Max from this numbers = {NumberOne}");
    }


if(NumberOne < NumberTwo)
    {
        Console.WriteLine($"Max from this numbers = {NumberTwo}");
    }

if(NumberOne == NumberTwo)
    {
        Console.WriteLine("Numbers are equal");
    }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.WriteLine("Input three numbers");
int NumberOne = Convert.ToInt32(Console.ReadLine());
int NumberTwo = Convert.ToInt32(Console.ReadLine());
int NumberThree = Convert.ToInt32(Console.ReadLine());
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.WriteLine("Input one number");
int NumberOne = Convert.ToInt32(Console.ReadLine());
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.WriteLine("Input one number");
int NumberOne = Convert.ToInt32(Console.ReadLine());
*/
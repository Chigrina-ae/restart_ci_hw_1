// Урок 2. Базовые алгоритмы

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// first variant
/*

int ShowSecond(int Num)
    {
        int Result = ( Num / 10 ) % 10;
        return Result;     
    }

int Number = new Random().Next(100,1000);
int SecondNum = ShowSecond(Number);

Console.WriteLine($"The second number  from {Number} is {SecondNum}");

*/

//second variant
/*

int ShowSecond(int Num)
    {
        int Result = ( Num / 10 ) % 10;
        return Result;     
    }

Console.WriteLine("Input three-digit number");
int Number = Convert.ToInt32(Console.ReadLine());
int CheckNum = Math.Abs(Number);

while (CheckNum < 100 | CheckNum > 999)
    {
        Console.WriteLine("Error. Input three-digit number");
        Number = Convert.ToInt32(Console.ReadLine());
        CheckNum = Math.Abs(Number);
    }

int SecondNum = ShowSecond(Number);
Console.WriteLine($"The second number  from {Number} is {Math.Abs(SecondNum)}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
int ShowLast(int Num)
    {
        int Result = Num % 10;
        return Result;    
    }

Console.WriteLine("Input number > two-digit number");
int Number = Convert.ToInt32(Console.ReadLine());

while (Math.Abs(Number) < 100)
    {
        Console.WriteLine("Error. Input number > two-digit number");
        Number = Convert.ToInt32(Console.ReadLine());
    }

int NumLast = ShowLast(Number);
Console.WriteLine($"The last number  from {Number} is {Math.Abs(NumLast)}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Week (int Num)
    {
        if (Num >= 6) return true;
        else return false;
    }


Console.WriteLine("Input number day of week from 1 to 7");
int Number = Convert.ToInt32(Console.ReadLine());

while (Number > 7 | Number < 1)
    {
        Console.WriteLine("Error. Input number day of week from 1 to 7");
        Number = Convert.ToInt32(Console.ReadLine());
    }

if (Number > 5) Console.WriteLine($"Is day {Number} weekend? - Yes");
else Console.WriteLine($"Is day {Number} weekend? - No");


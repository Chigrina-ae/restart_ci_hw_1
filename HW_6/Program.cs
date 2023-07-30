// Урок 6. Одномерные массивы. Продолжение


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


void Positives() 
    {
        int count = 0;
        Console.WriteLine("Input number of numbers:");
        int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Input number:");
                int a = Convert.ToInt32(Console.ReadLine());
                if(a > 0) count++;
            }
        Console.WriteLine($"Your number of positive numbers in amount of number is {count}");
    }

Positives();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
void Crossing()
{
    Console.WriteLine("Input b1:");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input k1:");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input b2:");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input k2:");
    double k2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2)
    {
        if (b1 == b2) Console.WriteLine("there is no spoon, all lines are one");
        else Console.WriteLine("The lines have nothing in common");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
    }
    Console.WriteLine($"Red lines were crossed here: ({x}, {y})");
}

Crossing();
*/

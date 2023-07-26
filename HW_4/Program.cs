// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
 int Exponent(int a, int b)
    {
        int step = a;
        for( int i = 1; i <= b-1; i++)
        step  = step * a;
        return step;
    }

Console.Write("Input a base numer "+" ");
int Base = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a exponent number "+" ");
int Exp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exponent(Base, Exp));
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int SumDigits(int Num)
    {
        int Sum = 0; 
        int Count = 0;
        while (Num>0)
            {
                int Unit = Num % 10;
                Sum = Sum + Unit;
                Num = Num / 10 ;
                Count++;
            }
        return Sum;
    }

Console.Write("Input a number"+" ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(Number));
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int InputNum (string mess) 
    {
        Console.WriteLine(mess);
        return Convert.ToInt32(Console.ReadLine());
    }

int[] CreateArray(int size)
    {
        int[]array = new int [size];
        for(int i = 0; i < size; i++)
        array[i] = InPut($"Input the number of the array under the index {i}");
        return array;
    }

void ShowArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        Console.WriteLine();
    }

int length = InputNum ("Input number of elements in the array");
int[] myArray  = CreateArray(length);
ShowArray(myArray);

*/
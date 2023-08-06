// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
    {
        double[,] array = new double[rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue+1), 1); 
        return array;
    }

void Show2dArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + " ");
            Console.WriteLine();
        }
    }

Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
    {
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(minValue, maxValue + 1);
        return array;
    }

void Show2dArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + " ");
            Console.WriteLine();
        }
    }

void PositionValue(int[,] array) 
    {
        Console.WriteLine("input row № from 0: ");
        int rowNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input column № from 0: ");
        int columnNum = Convert.ToInt32(Console.ReadLine());
        if (rowNum < array.GetLength(0) && columnNum < array.GetLength(1) && rowNum >= 0 && columnNum >= 0) 
            Console.WriteLine($"The number you seek is {array[rowNum, columnNum]}");
        else Console.WriteLine("We found nothing");
    }


Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
Console.WriteLine();
PositionValue(myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
    {
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(minValue, maxValue + 1);
        return array;
    }

void Show2dArray(int[,] array) 
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + " ");
            Console.WriteLine();
        }
    }

void ShowArr(double[] array) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");

        }
    }

double[] Average(int[,] array) 
    {
        double[] result = new double[array.GetLength(1)]; 
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                sum += array[i, j];
            double average = Math.Round((double)sum / array.GetLength(0), 2); 
            result[j] = average;
        }
        return result;
    }


Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
double[] resultArray = Average(myArray);
Console.WriteLine();
Console.WriteLine("That was a trip, but here are your averages for all the culumns in you array: ");
ShowArr(resultArray);
*/



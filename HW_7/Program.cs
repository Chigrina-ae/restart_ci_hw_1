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
            array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue+1), 1); // округлил до одного знака как в примере и int рандом, т.к. дабл дает от 0 до 1.
    return array;
}

// ну и везде double
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

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void PositionValue(int[,] array) //ну вот через void попробовал, мне кажется, тоже работает для этой задачи, логика как при bool, только вывод в консоль сразу внутри метода
{
    Console.WriteLine("input row №, my lord: ");
    int rowNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input column №, my lord: ");
    int columnNum = Convert.ToInt32(Console.ReadLine());
    if (rowNum < array.GetLength(0) && columnNum < array.GetLength(1) && rowNum >= 0 && columnNum >= 0) // собственно, булевая проверка фактичекски и вывод при true и при false ниже
        Console.WriteLine($"The number you seek is {array[rowNum, columnNum]}, my lord! Praise the Lord!");
    else Console.WriteLine("We found nothing, my lord, we appologize. May our lives bring you comfort *sounds of seppuku*");
}

// можно разбить войдовский на bool и на войд метод вывода, чтобы в тело программы не записывать if else, но я не знаю, что было бы оптимальнее в результате.
// ну или можно сделать метод double, тогда принимая интовый массив число всегда будет интовымб в результате переводим в дабл, а если проверка не пройдена - поставить условные 0,5 как условие для вывода сообщения об ошибке
// еще для интового метода можно сделать сортировку по максимальному, например, поставив его в array[0], и в else вывести array[0] +1, в программе тогда если значение метода меньше либо равно max, 
//то пишем значение, если больше - пишем ошибку

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
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // создаем массив
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array) // показываем
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void ShowArr(double[] array) // показываем наш новый массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}

double[] Average(int[,] array) // решил пойти через массив здесь
{
    double[] result = new double[array.GetLength(1)]; // инициализируем наш результат с размером в количество колонок
    for (int j = 0; j < array.GetLength(1); j++) // запускаем внешний цикл
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        double average = Math.Round((double)sum / array.GetLength(0), 2); // среднеарифметической закладываем во внешний, делим сразу на размер первоначального массива по рядам
        result[j] = average;
    }
    return result;
}

// попробую void для себя, программу не буду под него переписывать. Тогда не нужны методы под вывод одномерного массива, и строки под вывод

// void Average(int[,]array)
// {
//     Console.WriteLine();
//  for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//             sum += array[i, j];
//         double average = Math.Round((double)sum / array.GetLength(0), 2);
//         Console.Write($"{average}; ");    
//     }
// }


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



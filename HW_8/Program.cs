// Урок 8. Двумерные массивы. Продолжение


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void SortArray(int[,] array)
{
    int temp; // под сортирвку
    for (int i = 0; i < array.GetLength(0); i++) // строки не трогаем до конца сортировки в столбцах, шагаем после окончания сортировки строки
        for (int j = 0; j < array.GetLength(1) -1; j++) // шагаем на +1 после сортировки по наименьшему, осталвяя его нетронутым
            for (int k = j + 1; k < array.GetLength(1); k++) //  сортировка по наименьшему
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
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
int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
Console.WriteLine();
SortArray(myArray);
Show2dArray(myArray);
*/



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void ShowArr(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] SumString(int[,] array)
{
    int[] sumList = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumList[i] = sum;
    }
    return sumList;
}

int Lowest(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]<array[result]) result = i;
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
Console.WriteLine();
int[] sums = SumString(myArray);
Console.WriteLine("All sums in strings in order are:");
ShowArr(sums);
int lowestSum = Lowest(sums) +1;
Console.WriteLine();
Console.WriteLine($"string with lowest sum of elements is string №{lowestSum} (in our perfectly human numbers, that we, ordinary human beings, count from 1 (c) Mark Zukerberg)");
*/




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool CheckForPossibility(int[,] array, int[,] array2) //проверяем на возможность умножения

{
    bool check;
    if (array.GetLength(1) == array2.GetLength(1)) check = true; // собственно, условие
    else check = false;
    return check;
}

int[,] MatrixMultiplication(int[,] array, int[,] array2) // я вообще не отвечаю за то, что здесь, как гуманитарий с огромным стажем, я немного поломался и даже если увижу результат..
{

    int[,] result = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array[i, k] * array2[k, j];
            }
        }
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

Console.WriteLine("input rows2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns2: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min2: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max2: ");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] myArray2 = CreateRandom2dArray(rows, columns, min, max);

Show2dArray(myArray);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();

bool check = CheckForPossibility(myArray, myArray2);

if (check == true)  // что тоже можно было бы в void запихнуть, кажется
{
    int[,] result = MatrixMultiplication(myArray, myArray2);
    Console.WriteLine("Multiplication result is: ");
    Show2dArray(result);
}
else Console.WriteLine("Ahoy, lad! No can do yer multiplies, yaarrrrrr!");
*/




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] CreateRandom3dArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show3dArray(int[,,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.WriteLine($"{array[i, j, k]}  ({i}, {j}, {k})"); // если я верно понял, что подразумевалось под "построчно" выводить
    Console.WriteLine();

}

Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input depth: ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,,] myArray = CreateRandom3dArray(rows, columns, depth, min, max);
Show3dArray(myArray);
*/



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
int[,] Create2dSpiralArray(int rows, int columns)
{
    int index = 1;
    int[,] array = new int[rows, columns];
    int startRow = 0;
    int endRow = rows - 1;
    int startColumn = 0;
    int endColumn = columns - 1;

    while (index <= rows * columns) //  т.к. шагает от 0 по одному - количество шагов будет равно произведению (площади)
    {
        // верхний ряд
        for (int i = startColumn; i <= endColumn; i++) //бежим по первой строке
        {
            array[startRow, i] = index;
            index++;
        }
        startRow++; // т.к. заполнена

        // правый столб
        for (int i = startRow; i <= endRow; i++) // бежим попоследнему столбцу
        {
            array[i, endColumn] = index;
            index++;
        }
        endColumn--; // т.к. заполнен

        // нижний ряд
        if (startRow <= endRow) // в обратную сторону цикл не должен заходить, а вот равенство будет скорее всего в какой-то момент
            for (int i = endColumn; i >= startColumn; i--)
            {
                array[endRow, i] = index;
                index++;
            }
        endRow--;

        //левый ряд
        if (startColumn <= endColumn)
            for (int i = endRow; i >= startRow; i--)
            {
                array[i, startColumn] = index;
                index++;
            }
        startColumn++;
    }
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


Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] spiral = Create2dSpiralArray(rows, columns);
Show2dArray(spiral);
*/

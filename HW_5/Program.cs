// Урок 5. Функции и одномерные массивы

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int [] CreateRandomArray(int size) 
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
          array[i] = new Random().Next(100, 1000); 
    }
    return array;
}

void ShowArr(int[]array)
{
    Console.Write("Your array is [ "); 
    for(int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int EvenCount(int[]array)
{
        int count = 0; 
    for(int i = 0; i < array.Length; i++) 
        {
            if (array[i]%2 == 0) count++; 
        }
        return count;
}

Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] thrreeDigitArray = CreateRandomArray(length);
ShowArr(thrreeDigitArray);
int evenCount = EvenCount(thrreeDigitArray);
Console.WriteLine(); 
Console.WriteLine($"There are {evenCount} even numbers in array");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1); 
    }
    return array;
}

void ShowArr(int[] array)
{
    Console.Write("Here is your array, mate: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]"); 
}

int OddSum(int[] array)
{
    int sum = array[1];
    for (int i = 3; i < array.Length; i += 2)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max of array: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length, min, max);
ShowArr(array);
if (array.Length > 1)  
{
    int oddSum = OddSum(array);
    Console.WriteLine(); 
    Console.WriteLine($"Sum of odds in array is {oddSum}, my dude");
}
else
{
    Console.WriteLine();
    Console.WriteLine("We need more numbers, my dude");
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*
double[] Array()
{
    Console.Write("Input length: ");
    int length = Convert.ToInt32(Console.ReadLine());
    double[] result = new double[length]; //setting up length first, we will need it later
    for (int i = 0; i < length; i++) //setting up cycle
    {
        Console.Write("Input an item: "); //requesting numbers
        double number = Convert.ToDouble(Console.ReadLine());
        result[i] = number; //we increase i from zero, each number gets its spot
    }

    return result; //getting massive as result
}

void ShowArr(double[] array)
{
    Console.Write("Here is your array, mate: [  ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.Write(" ]"); //this will make an array look like an array
}

double DiffMaxMin(double[] array)
{
    double maxVal = array[0];
    double minVal = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (maxVal <= array[i]) maxVal = array[i];
        else if (minVal >= array[i]) minVal = array[i];
    }
    double result = (maxVal - minVal);
    result = Math.Round(result, 2); //in one occasion somehow got periodic number (16,7 - 1,8), went to 14,8999999999. It is correct, but decided to make it look bettr, got to look up for method though
    return result;
}

double[] array = Array();
ShowArr(array);
double diffMaxMin = DiffMaxMin(array);
Console.WriteLine();
Console.WriteLine($"Difference between maximal and minimal number in your array is {diffMaxMin} my dude");
*/

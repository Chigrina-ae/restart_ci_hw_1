// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num  > 1) ShowNums(num -1);
}

Console.WriteLine("input your N (number), write it, do it: ");
int nombre = Convert.ToInt32(Console.ReadLine());
Console.Write("Countdown from your nombre -> ");
 ShowNums(nombre);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int DigitSum(int num1, int num2)
{
    if (num2 > num1)
    {
        return DigitSum(num1, num2 - 1) + num2;
    }
    else if (num2 < num1)
    {
        return DigitSum(num1, num2 + 1) + num2;
    }
    else return (num1);
}

Console.WriteLine("input your nombre 1 (number 1), write it, do it: ");
int nombreUno = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input your nombre 2 (number 2), write it, do it: ");
int nombreDos = Convert.ToInt32(Console.ReadLine());
int sum = DigitSum(nombreUno, nombreDos);
Console.WriteLine(sum);
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

это готовая программа, фактически
*/
/*
int Akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Akkerman(m - 1, 1);
else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("input your nombre 1 (number 1), write it, do it: ");
int nombreUno = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input your nombre 2 (number 2), write it, do it: ");
int nombreDos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(nombreUno, nombreDos));
*/
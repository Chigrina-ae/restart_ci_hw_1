// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.WriteLine("Input first number");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int NumberTwo = Convert.ToInt32(Console.ReadLine());

if(NumberOne > NumberTwo)
    {
        Console.WriteLine($"Max from this numbers = {NumberOne}");
    }
else if (NumberOne < NumberTwo)
    {
        Console.WriteLine($"Max from this numbers = {NumberTwo}");
    }
else 
    {
        Console.WriteLine("Numbers are equal");
    }

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.WriteLine ("Input three numbers");
 
 int [] Numbers = new int [3];
 
 //Заполняем массив

Numbers [0] = Convert.ToInt32 (Console.ReadLine());
Numbers [1] = Convert.ToInt32 (Console.ReadLine());
Numbers [2] = Convert.ToInt32 (Console.ReadLine());

int i = 0;
int Max = Numbers[0];

while (i<3) 
  {if (Max<Numbers[i])
         {Max =Numbers[i];
         
         }         
  i=i+1;   
  }

Console.WriteLine ($"Max from this numbers = {Max}");
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.WriteLine("Input one number");
int NumberOne = Convert.ToInt32(Console.ReadLine());

if((NumberOne % 2) == 0)
    {
        Console.WriteLine("Number is even");
    }
else
    {
        Console.WriteLine("Number is odd");
    }
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// певый вариант решения
/*
Console.WriteLine("Input one number");
int NumberOne = Convert.ToInt32(Console.ReadLine());

while(NumberOne > 0)
    {
        if((NumberOne % 2) == 0)
            {
                Console.Write(NumberOne + " ");
            }
        
        NumberOne = NumberOne - 1;       
    }
*/

// второй вариант решения
/*
Console.WriteLine("Input one number");
int NumberOne = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i <= NumberOne; i++)
    {
        if((i % 2) == 0)
            {
                Console.Write(i + " ");
            }   
    }
    */
// Урок 3. Базовые алгоритмы. Продолжение

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int Palindrome (string Mess)
    {
        Console.Write(Mess);
        string Num = Console.ReadLine();
        int Result = Convert.ToInt32(Num);
        return Result;
    }
int Number = Palindrome("Input a five-digit number: ");
if(Math.Abs(Number) < 10000 || Math.Abs(Number) >= 100000)
    {
        Console.WriteLine("It isn't a five-digit number, input a five-digit number ");
        return;
    }
if(Number % 10 == Number / 10000 || Number / 10 % 10 == Number / 1000 % 10)
    {
        Console.WriteLine("It is palindrome");
    }
else
    {
        Console.WriteLine("It isn't palindrome");
    }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/* 
int Coordinata(string cordin, string point)
    {
        Console.Write("Введите координату " + cordin + " точки " + point + ": ");
        return Convert.ToInt16(Console.ReadLine());
    }
int x1 = Coordinata("x", "A");
int y1 = Coordinata("y", "A");
int z1 = Coordinata("z", "A");
int x2 = Coordinata("x", "B");
int y2 = Coordinata("y", "B");
int z2 = Coordinata("z", "B");

double Solut(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
    {
        return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                        Math.Pow((y2-y1), 2) + 
                        Math.Pow((z2-z1), 2));
    }

double Length =  Math.Round(Solut(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine("Длина отрезка " + Length);
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 4
// 1 - 1
// 2 - 8
// 3 - 27
// 4 - 64

/* 
int Polin (string mess)
    {
        Console.Write(mess);
        string chis = Console.ReadLine();
        int result = Convert.ToInt32(chis);
        return result;
    }

int chislo = Polin("Введите число ");
int chis = 1;
int kvadrat = 0;
while(chis <= chislo)
    {
        kvadrat = chis * chis;
        Console.WriteLine(chis + "-" + kvadrat);
        chis++;
    }
*/
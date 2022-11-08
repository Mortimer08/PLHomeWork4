// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа:");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе (натуральное) число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Хотя 0 - не натуральное число, этот показатель степени не исключён
// ответ получается корректный

if (number2 < 0)
{
    Console.WriteLine("Введено отрицательное число, берём его модуль");
    number2 = Math.Abs(number2);
}

int exponentiation = Exponentiation(number1,number2);
Console.WriteLine($"{number1} в степени {number2} равно {exponentiation}");

int Exponentiation(int num1, int num2)
{
    int exp = 1;
    for (int i = 0; i < num2; i++)
    {
        exp *= num1;
    }
    return exp;
}
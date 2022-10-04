// Задача 25: Напишите метод, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();

WriteLine("Введите число:  ");
int A = Convert.ToInt32(Console.ReadLine());
WriteLine("Введите число:  ");
int B = Convert.ToInt32(Console.ReadLine());
int exponent = A;

for (int i = 1; i < B; i++)
{
exponent = exponent * A;
}
WriteLine($"A в степени B равно: {exponent}");
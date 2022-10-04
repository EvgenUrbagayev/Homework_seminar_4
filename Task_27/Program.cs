// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

WriteLine("Введите число:  ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (A > 0)
{
    int number = A % 10;
    A = A / 10;
    sum = sum + number;
}
WriteLine ($"Сумма всех цифр в числе равна: {sum}" );
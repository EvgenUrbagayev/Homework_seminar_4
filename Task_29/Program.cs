// Задача 29: Напишите метод, который формирует массив
// из 8 случайных элементов и выводит их на экран.

using static System.Console;
Clear();
int[] myArray = new int[8];
{
    for(int i=0; i < 8; i++)
    {
        myArray[i] = new Random().Next(0, 34);
        Write($"{myArray[i]}, ");
    }
}
WriteLine();




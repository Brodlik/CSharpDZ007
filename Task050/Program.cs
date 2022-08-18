// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Write("Введите номер строки:");
int row = Convert.ToInt32(Console.ReadLine()) - 1;

Console.Write("Введите номер столбца:");
int column = Convert.ToInt32(Console.ReadLine()) - 1;

int n = 10;
int m = 10;

Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Массив:");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(0, 100);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
if (row < 0 | row > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемент лежит вне рамок заданного массива");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", array[row, column]);
}
Console.ReadLine();

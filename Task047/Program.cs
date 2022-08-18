// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = -10, int rightRange = 100) // метод заполения матрицы случайными числами
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rand.Next(leftRange, rightRange + 1));
        }
    }

    return matrix;
}
void PrintMatrix(double[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
double[,] Matrix = FillMatrixRandomNumbers(m, n); //вызов метода заполения матрицы случайными числами
PrintMatrix(Matrix);// вызов метода печати матрицы вместо Console.WriteLine...
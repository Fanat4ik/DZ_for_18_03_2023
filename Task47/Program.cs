// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray2D(double [,] array2D)
{
    Random random = new Random();

    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            array2D[i, j] = (random.NextDouble() * 10) - (random.NextDouble() * 10);
        }
    }
}

void PrintArray2D(double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            System.Console.Write($"{Math.Round(array2D[i, j],2)} ");
        }
        System.Console.WriteLine();
    }
}

int m = 3;
int n = 4;

double[,] array2D = new double[m, n];
FillArray2D(array2D);
PrintArray2D(array2D);
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//заполнение массива случайными int до 10
void FillArray2D(int [,] array2D)
{
    Random random = new Random();

    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            array2D[i, j] = random.Next(10);
        }
    }
}

//печать массива в консоль
void PrintArray2D(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

//выводит в консоль среднее арифметическое каждого столбца массива
void ShowAverageEachColumnOfTheArray2D(int [,] array2D)
{
        if(array2D == null || array2D.GetLength(0) == 0 || array2D.GetLength(1) == 0)
    {
        Console.WriteLine("Массив пуст!");
        return;
    }
// TODO LATE
}

int rowsArray2D = 3;
int colonsArray2D = 4;

int[,] array2D = new int[rowsArray2D, colonsArray2D];
FillArray2D(array2D);
PrintArray2D(array2D);
ShowAverageEachColumnOfTheArray2D(array2D);
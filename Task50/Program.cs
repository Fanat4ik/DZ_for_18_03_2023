// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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

//запрос int из консоли
int GetDoubleFromConsole(string name)
{
    System.Console.Write($"Введите {name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

//показывает значение элемента массива
void ShowArrayElementValue(int [,] array2D)
{
    if(array2D == null || array2D.GetLength(0) == 0 || array2D.GetLength(1) == 0)
    {
        Console.WriteLine("Массив пуст!");
        return;
    }
    int row = GetDoubleFromConsole("укажите номер ряда");
    int colon = GetDoubleFromConsole("укажите номер столбца");
    if (row > (array2D.GetLength(0)-1) || colon > (array2D.GetLength(1)-1))
    {
        Console.Write($"такого элемента [{row},{colon}] нет в массиве");
        return;
    }
    Console.Write($"значение элемента [{row},{colon}] равно: {array2D[row, colon]}");
}

int rowsArray2D = 3;
int colonsArray2D = 4;

int[,] array2D = new int[rowsArray2D, colonsArray2D];
FillArray2D(array2D);
PrintArray2D(array2D);
ShowArrayElementValue(array2D);
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:F2}"+" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mini value of element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of element");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

Print2DArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
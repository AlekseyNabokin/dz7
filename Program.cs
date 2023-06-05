// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]:F2}"+" ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mini value of element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Print2DArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]:F2}"+" ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mini value of element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the line position: ");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the column position: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Print2DArray(myArray);

// if (m2<1 || n2<1)
// Console.WriteLine("Row positions cannot be negative");
// else if (m2 <= rows+1 && n2 <= columns+1)
// Console.WriteLine($"The value of the element is {myArray[m2-1,n2-1]:F2}" );
// else Console.WriteLine("There is no such element in the array");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+" ");
        }
        Console.WriteLine();
    }
}

void arif(int[,] array)
{
    Console.Write("Arithmetic mean of each column: ");
    Random rand = new Random();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum/(array.GetLength(0)):F1}; ");
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

int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
arif(myArray);

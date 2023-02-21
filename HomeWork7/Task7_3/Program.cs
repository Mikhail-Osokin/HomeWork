/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

int [,] InitMatrix()
{
    int [,] matrix = new int [3,4];
    Random rmd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rmd.Next(-9,10);
        }
    }
return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}

void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double [] AverageRoWMatrix(int [,] matrix)
{
    double [] average = new double [matrix.GetLength(1)];
    average[0] = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average[i] = average[i] + matrix[j,i];
        }
    average[i] = average[i]/matrix.GetLength(0);
    }
return average;
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
double [] average = AverageRoWMatrix(matrix);
Console.WriteLine();
PrintArray(average);

/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int GetNumber()
{
    int result;
    while (true)
    {
        Console.WriteLine("Введите позицию в двумерном массиве ");

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }
    }
    return result;
}

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

void GetElementMatrFromPosition(int [,] matrix, int number)
{
    if (number > matrix.GetLength(0)*matrix.GetLength(1))
    {
        Console.WriteLine("Числа с такой позицией в заданном массиве нет");
    }
    else if (number%matrix.GetLength(1)==0)
    {
       Console.WriteLine($"Элемент двумерного массива с позцией {number} = {matrix[number/matrix.GetLength(1)-1,matrix.GetLength(1)-1]}"); 
    }
    else 
    {
        Console.WriteLine($"Элемент двумерного массива с позцией {number} = {matrix[number/matrix.GetLength(1),number%matrix.GetLength(1)-1]}");
    }
}

int position = GetNumber();
int [,] matrix = InitMatrix();
PrintMatrix(matrix);
GetElementMatrFromPosition(matrix,position);
/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int [,] InitMatrix()
{
    int [,] matrix = new int [4,4];
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

int [,] MultiplyMatrix(int [,] matrA, int [,] matrB)
{
    int [,] result = new int [matrA.GetLength(0),matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
        {
            for (int j = 0; j < matrB.GetLength(1); j++)
            {
                for (int k = 0; k < matrB.GetLength(0); k++)
                {
                    result[i,j] = result[i,j] + matrA[i,k]*matrB[k,j];
                }
            }
        }
return result;   
}

int [,] matrA = InitMatrix();
int [,] matrB = InitMatrix();
PrintMatrix(matrA);
Console.WriteLine();
PrintMatrix(matrB);
Console.WriteLine();
int [,] mult = MultiplyMatrix(matrA,matrB);
if (matrA.GetLength(0) != matrB.GetLength(1)) 
    {
        Console.WriteLine("Матрицы невозможно перемножить");
    }
else
{
    PrintMatrix(mult);
}
/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int [,] FillMatrix()
{
    int [,] matrix = new int [6,6];
    int i = 0;
    int j = 0;
    int k = 0;
    for (int count = 1; count <= matrix.GetLength(0)*matrix.GetLength(1); count++)
        {
            matrix[i,j] = count;
            if (i==k && j < matrix.GetLength(0) - 1 - k)
            {
                j++;
            }
            else if (j == matrix.GetLength(0) - 1 - k && i < matrix.GetLength(0) - 1 - k)
            {
                i++;
            }
            else if (i==matrix.GetLength(0) - 1 - k && j > k)
            {
                j--;
            }
            else if (j == k && i > k+1)
            {
                i--;
            }
            if (i == k+1 && j == k && k != matrix.GetLength(0) - 1 - k)
            {
                k++;
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
            if (matrix[i,j]/10 == 0)
            {
                Console.Write($"0{matrix[i,j]} ");
            }
            else
            {
                Console.Write($"{matrix[i,j]} ");
            }
        }
    Console.WriteLine();
    }
}

int [,] matrix = FillMatrix();
PrintMatrix(matrix);
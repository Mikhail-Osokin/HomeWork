/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int [] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100,1000);
    }
    return result;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountEvenNumbersOfArray(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) 
            count++;
    }
return count;
}

int [] arr = InitArray();
PrintArray(arr);
int count = CountEvenNumbersOfArray(arr);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count}");
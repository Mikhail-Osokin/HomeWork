/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int GetNumber(string message)

{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Ввели некорректное число. Повторите ввод");
    }
    return result;
}

int [] InitArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = GetNumber($"Введите {i+1}-е число: ");
    }
    return result;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

void CountPositive(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++;
    }
Console.WriteLine($"количество положительных чисел = {count}");
}

int lenght = GetNumber("Введите количество чисел: ");
int [] arr = InitArray(lenght);
PrintArray(arr);
CountPositive(arr);

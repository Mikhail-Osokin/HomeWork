/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result>=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод");
        }
    }

    return result;
}

int GetSumNaturalNumbers(int numberN, int numberM)
{
    if (numberM==numberN)
    {
        return numberN;
    }
    return numberM + GetSumNaturalNumbers(numberN,numberM+1);
    
}

int numberM = GetNumber("Введите число M: ");
int numberN = GetNumber("Введите число N: ");
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} = {GetSumNaturalNumbers(numberN,numberM)}");
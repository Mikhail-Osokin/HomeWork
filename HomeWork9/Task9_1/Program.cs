/*
 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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

string AllNaturalNumbers(int numberN)
{
    if (numberN == 1)
    {
        return "1";
    }
    return numberN.ToString() + ", " + AllNaturalNumbers(numberN-1);
}

int numberN = GetNumber("Введите число: ");
string result = AllNaturalNumbers(numberN);
Console.WriteLine();
Console.WriteLine($"Все натуральные числа от 1 до {numberN} - {result}");
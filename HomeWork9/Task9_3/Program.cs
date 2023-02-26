/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

double GetNumber(string message)

{
    double result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result) && result>=1)
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

double Ackerman(double numberM, double numberN)
{
    if (numberM == 0)
    {
       return numberN + 1;
    }
    else if (numberN == 0)
    {
        return Ackerman(numberM-1, 1);
    }
    return Ackerman(numberM - 1, Ackerman(numberM, numberN-1));
}

double numberM = GetNumber("Введите число M: ");
double numberN = GetNumber("Введите число N: ");
Console.WriteLine();
Console.WriteLine($"Функция Аккермана от чисел {numberM} и {numberN} = {Ackerman(numberM, numberN)}");
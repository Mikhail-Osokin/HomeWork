/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Повторите ввод");
        }
    }

    return result;
}

int x = GetNumber("Введите пятизначное число");
if (x<10000||x>99999)
{
    Console.WriteLine("Вы не ввели пятизначное число");
}
else
{
    if (x/10000==x%10 && (x/1000-x/10000*10)==(x%100-x%10)/10)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Random rmd = new Random();
    int result = rmd.Next(100, 1000); // [left, right)
    return result;
}

int ShowSecondDigitOfNumber(int number)
{
    int secondDigit = ((number % 100) - (number % 10))/10;
    return (secondDigit);
}

int number = GetNumber();
int result = ShowSecondDigitOfNumber(number);

Console.WriteLine($"Вторая цифра числа {number} = {result}");


//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
// while (num >= 100 && num <= 999)
// {
//     num = num / 10;
// }
// int secondDigit = num % 10;
// Console.Write($"Вторая цифра числа: {secondDigit}");
switch (num)
{
    case < 100:
    Console.WriteLine("Число не трехзначное");
    break;
    case > 999:
    Console.WriteLine("Число не трехзначное");
    break;
    case >= 100:
    while (num >= 100 && num <= 999)
    {
        num = num / 10;
    }
    int secondDigit = num % 10;
    Console.WriteLine($"Вторая цифра числа {secondDigit}");
    break;
}

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case < 100:
    Console.WriteLine("Третьей цифры в числе нет");
    break;
    case >= 100:
    while (num > 999)
    {
        num = num / 10;
    }
    int thirdDigit = num % 10;
    Console.WriteLine($"Третья цифра числа {thirdDigit}");
    break;
}

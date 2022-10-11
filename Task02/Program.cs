// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число от 1 до 7 и я скажу это выходной или нет");
int numberOne = Convert.ToInt32(Console.ReadLine());
switch (numberOne)
{
    case 1:
        Console.Write("Нет");
        break;
    case 2:
        Console.Write("Нет");
        break;
    case 3:
        Console.Write("Нет");
        break;
    case 4:
        Console.Write("Нет");
        break;
    case 5:
        Console.Write("Нет");
        break;
    case 6:
        Console.Write("Да");
        break;
    case 7:
        Console.Write("Да");
        break;
    default:
        Console.Write("Нет такого дня недели");
        break;
}
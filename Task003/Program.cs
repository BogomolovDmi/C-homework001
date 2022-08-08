// Домашнее задание номер 3
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа для определения чётности числа");
Console.WriteLine("Введите число");
string numberstring1 = Console.ReadLine();
int number1 = int.Parse(numberstring1);

if (number1%2==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
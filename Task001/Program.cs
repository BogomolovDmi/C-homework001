// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа для определения наибольшего и наименьшего чисел");
Console.WriteLine("Введите первое число");

string numberstring1 = Console.ReadLine();
int number1 = int.Parse(numberstring1);

Console.WriteLine("Введите второе число");

string numberstring2 = Console.ReadLine();
int number2 = int.Parse(numberstring2);

if (number1 > number2)
{
    Console.WriteLine("Первое число является наибольшим, второе число является наименьшим");
}

else
{
    Console.WriteLine("Второе число является наибольшим, первое является наименьшим");
}
// Домашнее задание номер 2
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Программа для определения наибольшего из 3х чисел");
Console.WriteLine("Введите первое число");
string numberstring1 = Console.ReadLine();
int number1 = int.Parse(numberstring1);
Console.WriteLine("Введите второе число");
string numberstring2 = Console.ReadLine();
int number2 = int.Parse(numberstring2);
Console.WriteLine("Введите третье число");
string numberstring3 = Console.ReadLine();
int number3 = int.Parse(numberstring3);
int numberMax = number1;
if (number2 > number1)
{
    numberMax = number2;
}
if (number3 > numberMax)
{
    numberMax = number3;
}

Console.WriteLine("Максимальное число" + numberMax);
// Домашняя работа номер 4
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Программа для вывода чётных чисел");
Console.WriteLine("Введите число больше 1");
string numberstring1 = Console.ReadLine();
int number1 = int.Parse(numberstring1);

int i = 1;
while(i<=number1)
if (i%2==0)
{
    Console.WriteLine(i);
    i +=1;
}
else
{
    i +=1;
}

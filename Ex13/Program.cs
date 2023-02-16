/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;

while (Math.Abs(temp) > 999)
{
    temp = temp / 10;
}
if (Math.Abs(temp) > 99)
{
    temp = temp % 10;
    Console.WriteLine($"{n} -> {Math.Abs(temp)} - третья цифра");
}
else
{
    Console.WriteLine($"{temp} -> третьей цифры нет");
}
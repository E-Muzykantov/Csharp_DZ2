/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(n) > 99 && Math.Abs(n) < 1000)
{
    int result = (n / 10) % 10;
    Console.WriteLine($"{n} -> {Math.Abs(result)}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}

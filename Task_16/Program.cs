/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. */

Console.Clear();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a*a == b)
{
    Console.WriteLine($"b = {b} kvadrat a = {a}");
}
else if (b*b == a)
{
    Console.WriteLine($"a = {a} kvadrat b = {b}");
}
else
{
    Console.WriteLine("Ne kvadrati");
}
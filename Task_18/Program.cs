/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y) */

Console.Clear();
Console.Write("enter number of the quarter (from 1th to 4th): ");
int x = int.Parse(Console.ReadLine());


if (x < 1 || x > 4)
{
    Console.WriteLine("not a quarter");
}
else if (x == 1)
{
    Console.WriteLine("x > 0, y > 0");

}
else if (x == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (x == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else
{
    Console.WriteLine("x > 0, y < 0");
}
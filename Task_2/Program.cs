Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a>b)
{
    Console.WriteLine($"Большее число: {a}");
    Console.WriteLine($"Меньшее число: {b}");
}
else
{
    Console.WriteLine($"Большее число: {b}");
    Console.WriteLine($"Меньшее число: {a}");
}
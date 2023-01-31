/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления. */
Console.Clear();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (b%a == 0)
{
    Console.WriteLine($"{b} kratno {a}");
}
else
{
    Console.WriteLine($"Ne kratno, ostatok: {b%a}");
}
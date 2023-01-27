Console.Clear();
int a = new Random().Next(-10,10);
int b = new Random().Next(-10,10);
int c = new Random().Next(-10,10);
Console.WriteLine("Числа: "+a+" "+b+" "+c);
int max = a;

if (max<b)
{
    max = b;
}

if (max < c)
{
    max = c;
}

Console.WriteLine("Максимальное число: "+max);



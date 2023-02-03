// Напишите программу, которая на вход принимает координаты точек A и B и возвращает расстояние между ними в 2d пространстве
// A(x1,y1) B(x2,y2)
// sqrt((x1-x2)^2 + (y1 - y2)^2)

Console.Clear();
Console.Write("Enter A(x): ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter A(y): ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Enter A(z): ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Enter B(x): ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter B(y): ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Enter B(z): ");
double z2 = double.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"d = {dist:f3}");
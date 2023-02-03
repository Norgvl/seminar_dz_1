Console.Clear();
Console.Write("enter 'X' coordinate (not equal to 0): ");
int x = int.Parse(Console.ReadLine());
Console.Write("enter 'Y' coordinate (not equal to 0): ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y ==0)
{
    Console.WriteLine("coordinate equal to 0");
}
else if (x>0 && y>0)
{
    Console.WriteLine("first quarter");

}
else if (x<0 && y>0)
{
    Console.WriteLine("second quarter");
}
else if (x<0 && y<0)
{
    Console.WriteLine("third quarter");
}
else
{
    Console.WriteLine("fourth quarter");
}
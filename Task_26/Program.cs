Console.Clear();
int a = int.Parse(Console.ReadLine());
void S(int a)
{
    int count = 0;
    if(Convert.ToInt32(a) > 0)
    {
        while (a > 0)
        {
            a /= 10;
            count++;

        }
        Console.WriteLine(count);
    }
    else
    {
        while (a < 0)
        {
            a /= 10;
            count++;

        }
        Console.WriteLine(count);
    }
}

S(a);
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("enter the number: ");
int N = int.Parse(Console.ReadLine());
if (N < 0)
{
    N = N * (-1);
}
else if (N == 0)
{
    Console.WriteLine("0");
    return;
}


double[] arr = new double[N];

void Count(double[] arr, int N)
{

    for (int i = 0; i < N; i++)
    {
        double a = i + 1;
        arr[i] = Math.Pow(a, 2);
    }

}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Count(arr, N);
PrintArray(arr);
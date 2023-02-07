//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

Console.Clear();
int[] arr = new int[8];

void FillAndPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i]+ " ");
    }
}

FillAndPrint(arr);
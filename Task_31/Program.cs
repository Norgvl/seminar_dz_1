//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();

int[] arr = new int[12];

void FillAndWriteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);

    }
    Console.Write($"[{String.Join(", ", arr)}]");
}

int[] CountElements(int[] arr)
{
    int[] list = new int[2];
    foreach (int el in arr)
    {
        list[0] += el > 0 ? el : 0; 
        list[1] += el < 0 ? el : 0;
    }
    return list;
}

FillAndWriteArr(arr);
int[] mas = CountElements(arr);
Console.WriteLine("\n"+"Сумма отрицательных элементов: "+mas[1]+"Сумма положительных элементов: "+mas[0]);
// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] arr = new int [4]; 
void FillAndWriteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);

    }
    Console.Write($"[{String.Join(", ", arr)}]");
}

void Change(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);

    }

}

FillAndWriteArr(arr);
Change(arr);
Console.WriteLine(" " + String.Join(" ", arr));
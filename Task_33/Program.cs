//**Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

Console.Clear();
Console.WriteLine("Type elements of the array with spaces");
string elements = Console.ReadLine();
Console.Write("Find: ");
int find = int.Parse(Console.ReadLine());
int[] arr = FillAndWriteArr(elements);
if(FindNumber(arr, find))
{
    Console. WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
int[] FillAndWriteArr(string elements)
{
    string[] nums = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[nums.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(nums[i]);

    }
    return array;

}

bool FindNumber(int[] arr, int find)
{
    foreach (var el in arr)
    {
        if (el == find) return true;
    }
    return false;
 
}



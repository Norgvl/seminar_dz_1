Console.Clear();
int a = new Random().Next(100, 1000);

int[] Splitting(int a)
{
    int[] arr = new int[3];
    int a11 = a / 10;     // десятки
    int a21 = a % 100;     // единицы
    arr[0] = a / 100;     // сотни
    arr[1] = a11 - arr[0] * 10; // десятки
    arr[2] = a21 - arr[1] * 10;  // единицы
    return arr;

}


int[] arr = Splitting(a);
Console.WriteLine(a + " " + arr[0] + " " + arr[1] + " " + arr[2]);
Console.WriteLine(arr[0]+""+arr[2]);
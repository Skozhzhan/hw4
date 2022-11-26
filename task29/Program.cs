// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] numbers(int a)
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-5, 7);
    }
    return arr;
}

string A(int[] a)
{
    string result = string.Empty;
    for (int i = 0; i < a.Length; i++)
    {
        result += ($"{a[i]} ");
    }
    return result;
}
Console.WriteLine(A(numbers(8)));
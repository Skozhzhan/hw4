// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение степени: ");
int b = Convert.ToInt32(Console.ReadLine());

int Method4(int a, int b)
{
    // возведение в степень
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
int res = Method4(a, b);
Console.WriteLine(res);
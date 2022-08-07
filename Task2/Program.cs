// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (N > 0)
{
    N = N / 10;
    result++;
}
Console.WriteLine($"Результат - {result}");
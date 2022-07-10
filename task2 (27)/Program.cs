/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

int N;
Console.WriteLine("Введите число:");
while (!int.TryParse(Console.ReadLine(), out N))
{
    System.Console.WriteLine("Введите корректное значение:");
}
int SumDigitsInNumber(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + (N % 10);
        N /= 10;
    }
    return sum;
}


 System.Console.WriteLine("Сумма цифр в числе равна:" + SumDigitsInNumber(N));



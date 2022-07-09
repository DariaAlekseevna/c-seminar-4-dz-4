/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int A;
int B;
Console.WriteLine("Введите число A и B:");
while ((!int.TryParse(Console.ReadLine(), out A)) || (!int.TryParse(Console.ReadLine(), out B)))
{
    System.Console.WriteLine("Введите корректное значение А и В заново:");
}


    double result = Math.Pow(A, B);
Console.WriteLine($"{A} ^ {B} = {result}");

// еще вариант через цикл
/* int result = A;
int i = 1;
while (i < B)
{
    result *= A;
    i++;
}

Console.WriteLine($"{A} ^ {B} = {result}"); */

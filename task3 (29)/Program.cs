/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 50);
        index++;
    }

}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(array[position] + " ");
        position++;
    }
}

int[] array = new int [8]; //определили массив из 8 эл-тов

FillArray(array); //вызвали функцию заполнения массива
PrintArray(array); //вызвали функцию печати массива
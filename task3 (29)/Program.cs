/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

// слишком размытое условие задачи и примеры не подходят под условие, если делать как написано в условие задачи, то решение ниже

/* void FillArray(int[] array)
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

int[] array = new int [8]; //определила массив из 8 эл-тов

FillArray(array); 
PrintArray(array);  */

//если делать как вы говорили на семинаре, то есть пользователь сам вводит числа массива

void FillArray(int[] array)
{
    int index = 0;
    while (index < 8)
    {
        Console.Write("введите элемент массива:");
         array[index] =  int.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] col)
{
    int position = 0;
    while (position < 8)
    {
        if (position == 0)
        {
            Console.Write("[" + col[position]);
        }
        else if (position == 7)
        {
            Console.Write(col[position] + "]");
        }
        else
        {
            Console.Write(col[position] + ", ");
        }
        position++;
    }
}

int[] array = new int [8];


FillArray(array); //вызвала функцию заполнения массива
Console.WriteLine("массив из восьми элементов:");
PrintArray(array); //вызвала функцию печати массива
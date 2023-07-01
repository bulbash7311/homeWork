// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива:");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void arr(int a)
{
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(99, 999);
        Console.Write(array[i] + " ");
    }
}

int num(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            num = num + 1;
    }
    return num;
}

arr(a);
Console.Write($"\nКоличество чётных чисел в массиве: {num(array)}");
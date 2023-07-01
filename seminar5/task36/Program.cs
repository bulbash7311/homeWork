// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива:");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void arr(int a)
{
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
}

int num(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

arr(a);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {num(array)}");
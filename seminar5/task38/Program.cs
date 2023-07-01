// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];

void arr(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        array[i] = rand.NextDouble();
        Console.Write($"{array[i]:F2} ");
    }
}

double raznica(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i = i + 1;
    }
    return max - min;
}

arr(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raznica(array):F2}");
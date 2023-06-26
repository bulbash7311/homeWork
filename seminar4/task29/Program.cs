int ReadInt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());

    return result;
}

int[] ArrayGenerator(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

void printArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
        System.Console.Write($"{array[array.Length - 1]}");
        System.Console.Write("]");
}
int num = ReadInt("Введите размер массива: ");
int numMin = ReadInt("Введите начальное значение массива: ");
int numMax = ReadInt("Введите конечное значение массива: ");

int[] array = ArrayGenerator(num, numMin, numMax);

printArray(array);
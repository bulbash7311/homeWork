int ReadInt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    
    return result;
}

 int SumAllNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }

    return result;
}

int number = ReadInt("Введите число: ");
Console.WriteLine($"Сумма всех чисел {number} = {SumAllNumbers(number)}");
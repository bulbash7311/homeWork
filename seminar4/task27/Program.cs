int number = Prompt("Введите число:");

int Prompt(string message)
{
    System.Console.Write("Введите число");
    int result = Convert.ToInt32(Console.Readline());
    return result;
}

 int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }

    return result;
}

Console.WriteLine($"Сумма всех чисел {number} = {SumAllDigit(number)}");
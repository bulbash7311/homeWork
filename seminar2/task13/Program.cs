Console.WriteLine("Введите трехзначное число: ");

int numbers = Convert.ToInt32(Console.ReadLine());

if (numbers > 999)
{
    while (numbers > 999)
    {
        numbers = numbers / 10;

        if (numbers < 1000)
        {
            int result = numbers % 10;
            Console.WriteLine(result);
        }
    }
}

else if (numbers > 99)
{
    int result = numbers % 10;
    Console.WriteLine(result);
}

else Console.WriteLine("Введено неверное число!");
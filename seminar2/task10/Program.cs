Console.WriteLine("Введите трехзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

if (numbers > 99 && numbers <= 999)
{
    int second = (numbers / 10) % 10;

    Console.WriteLine(second);
}
else Console.WriteLine("Введено неверное число!");
Console.WriteLine("Введите номер дня недели: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5)
{
    Console.WriteLine("Нет, не выходной.");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Да, выходной!");
}
else if(num <=0 || num >= 8)
{
    Console.WriteLine("Такого дня недели нет!");
}
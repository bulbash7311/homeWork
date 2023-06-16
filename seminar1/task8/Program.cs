Console.WriteLine("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;

while (num2 <= num)
{
    if(num2 % 2 == 0)
    {
    Console.Write($"{num2} ");
    }
    num2 ++;
}
Console.WriteLine("Введите пятизначное число: ");

int numbers = Convert.ToInt32(Console.ReadLine());

int first = (numbers / 10000);
int second = (numbers / 1000) % 10;
int third = (numbers / 100) % 10;
int fourth = (numbers / 10) % 10;
int fifth = numbers % 10;

if (numbers <= 99999)
{
if(first == fifth && second == fourth)
{
    Console.WriteLine ("Это полиндром");
}
else Console.WriteLine ("Это не полиндром");
}
else Console.WriteLine("Введено неверное число!");
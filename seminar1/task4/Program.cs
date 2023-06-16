Console.WriteLine("Введите трехзначное число: ");

int numbers = Convert.ToInt32(Console.ReadLine());

int first = (numbers / 100);
int second = (numbers / 10) % 10;
int third = numbers % 10;

// Console.WriteLine (first + " " + second + " " + third);

if (first > second && first > third)
{
    Console.WriteLine ("max = " + first);
} else 

if (second > first && second > third)
{
    Console.WriteLine ("max = " + second);
} else 

if (third > first && third > second)
{
    Console.WriteLine ("max = " + third);
} else

if( first == second)
{
    Console.WriteLine ("Числа равны");
}
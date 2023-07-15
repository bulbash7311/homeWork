//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
int num = 0;

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int M, int N)
{
    num = num + N;

    if (N == M)
    {
        System.Console.Write("\n" + "Cумма натуральных элементов = " +num);
        return;
    }

    Numbers(M, N - 1);
}

if(M < N) Numbers(M,N);
else Numbers(N,M);
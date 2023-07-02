// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[4, 4];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(0, 100);
PrintMatrix(matrix);

int rows = ReadInt("Введите номер строки: ");
int cols = ReadInt("Введите номер столбца: ");

if (matrix.GetLength(0) >= rows && matrix.GetLength(1) >= cols) System.Console.Write(matrix[rows, cols]);

else System.Console.Write("Такого элемента нет!");
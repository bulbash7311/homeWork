//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] FillMatrix(int row, int col, double leftRange, double rightRange)
{
    double[,] tempMatrix = new double[row,col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = rand.NextDouble() * (leftRange - rightRange) + rightRange;
        }
    }
    return tempMatrix;
}

void PrintMatrix(double[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write($"{matrixForPrint[i,j]:F1}" + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
double [,] matrix = FillMatrix(rows, cols, -100, 100);
PrintMatrix(matrix);
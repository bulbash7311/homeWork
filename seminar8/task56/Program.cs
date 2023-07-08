// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
int count = 0;
int min = 0;
int[] sum = new int[matrix.GetLength(0)];

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int rows, int cols, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[rows, cols];
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

void RowsSum() //Суммирование строк матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum[i] = sum[i] + matrix[i, j];
        }
    }
}

void MatrixMinRows() //Нахождение наименьшей суммы
{
    for (int i = 0; i < sum.Length; i++)
    {
        count = 0;

        min = sum[count];

        while (count < sum.Length - 1)
        {
            if (sum[count] < min)
            {
                min = sum[count];
            }

            count++;
        }
    }
}

PrintMatrix(matrix);

System.Console.WriteLine("");

RowsSum();

MatrixMinRows();

System.Console.WriteLine("");

for (int j = 0; j < matrix.GetLength(0); j++)
{
    System.Console.Write(matrix[count, j] + "\t");
}
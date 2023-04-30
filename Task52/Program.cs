// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
   int[,] matrix = new int[rows, columns];
   Random rnd = new Random();

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rnd.Next(min, max + 1);
      }
   }
   return matrix;
}

void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j],5} ");
      }
      Console.WriteLine();
   }
}

double[] AvgValue(int[,] matrix)
{
   double[] avgMatrix = new double[matrix.GetLength(1)];
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
      double avg = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
         avg += matrix[i, j];
      }
      avgMatrix[j] = avg/matrix.GetLength(0);
   }
   return avgMatrix;
}
void PrintArray(double[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
      if (i < arr.Length - 1) Console.Write($"{arr[i],5} ");
      else Console.Write($"{arr[i],5}");
   }
}

int[,] matrix = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
double[] avgValue = AvgValue(matrix);
PrintArray(avgValue);

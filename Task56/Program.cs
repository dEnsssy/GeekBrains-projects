// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//  строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
   int h = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      Console.Write($"{h++}. ");
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j],5} ");
      }
      Console.WriteLine();
   }
}
int[] SumRow(int[,]matrix)
{
   int[] array = new int[matrix.GetLength(0)];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      int sum = 0;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         sum += matrix[i, j];
      }
      array[i] = sum;
   }
   return array;
}
void PrintArray(int[] arr)
{
   int h = 0;
   for (int i = 0; i < arr.Length; i++)
   {
      if (i < arr.Length - 1) Console.WriteLine($"Сумма {h++} строки = {arr[i]}, ");
      else Console.WriteLine($"Сумма {h++} строки = {arr[i]}, "); ;
   }
}
int FindMinRow(int[]sumRow)
{
   int min = sumRow[0];
   int position = 0;
   for (int i = 1; i < sumRow.Length; i++)
   {
      if (sumRow[i] < min)
      {
         min = sumRow[i];
         position = i;
      }
   }
   return position;
}

int[,] matrix = CreateMatrixRndInt(5, 3, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumRow = SumRow(matrix);
PrintArray(sumRow);
int findMinRow = FindMinRow(sumRow);
Console.WriteLine($"Строка с наименьшей суммой элементов: {findMinRow}.");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
bool ValueMatrixs(int[,] matrixA,int[,] matrixB)
{
   if (matrixA.GetLength(1)==matrixB.GetLength(0)) return true;
   return false;
}
int[,] MultiplicationTwoMatrixs(int[,] matrixA, int[,] matrixB)
{
   int[,] finishMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
  
         for (int i = 0; i < matrixA.GetLength(0); i++)
         {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
               for (int k = 0; k < matrixA.GetLength(1); k++)
               {
                  finishMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
               }
            }
   }
   return finishMatrix;
}


int[,] matrixA = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrixB);
Console.WriteLine();
if(ValueMatrixs(matrixA, matrixB))
{
   int[,] multiplicationTwoMatrixs = MultiplicationTwoMatrixs(matrixA, matrixB);
   PrintMatrix(multiplicationTwoMatrixs);
}
else Console.WriteLine("Перемножение матриц невозможно!");
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] CreateSpiralMatrix(int rows, int columns)
{
   int[,] matrix = new int[rows, columns];
   int value = 1;
   int i = 0;
   int j = 0;
   int rightDown = 0;
   int left = 0;
   int up = 0;
   int right = 0;
   while (value<=rows*columns)
   {
      // if (i == Ibeg && j < M - Jfin - 1)
      //    ++j;
      // else if (j == M - Jfin - 1 && i < N - Ifin - 1)
      //    ++i;
      // else if (i == N - Ifin - 1 && j > Jbeg)
      //    --j;
      // else
      //    --i;
      matrix[i, j] = value;
      if(i<=rightDown&&j<columns - right - 1) j++;
      else if (j==columns-right && i< rows-left-1) i++;
      else if (i==rows-left-1&&j>up) j--;
      else i--;
      if ((i==rightDown+1)&&(j==up)&&(up!=columns-right-1))
      {
         rightDown++;
         left++;
         up++;
         right++;
      }
      value++;
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

int[,] matrixA = CreateSpiralMatrix(5, 5);
PrintMatrix(matrixA);
Console.WriteLine();
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] Create3DArrayRndInt(int rows, int columns, int depth, int min, int max)
{
   int[,,] array3D = new int[rows, columns, depth];
   int value = 10;
   for (int i = 0; i < array3D.GetLength(0); i++)
   {
      for (int j = 0; j < array3D.GetLength(1); j++)
      {
         for (int k = 0; k < array3D.GetLength(1); k++)
         {
            array3D[i, j, k] = value++;
         }
      }
   }
   return array3D;
}
void Print3DArray(int[,,] array3D)
{
   for (int i = 0; i < array3D.GetLength(0); i++)
   {
      for (int j = 0; j < array3D.GetLength(1); j++)
      {
         for (int k = 0; k < array3D.GetLength(2); k++)
         {
            Console.Write($"{array3D[i, j, k],5} ({i},{j},{k}) ");
         }
      }
      Console.WriteLine();
   }
}
bool ValueArray(int[,,] array3D)
{
   if (array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2) > 91) return false;
   else return true;
}


int[,,] array3D = Create3DArrayRndInt(2, 2, 2, -10, 10);
if (ValueArray(array3D))
{
   Print3DArray(array3D);
   Console.WriteLine();
}
else Console.WriteLine("Массив слишком большой,чтобы заполнять его неповторяющимися двузначными числами");
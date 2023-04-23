// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
   double[] arr = new double[size];
   Random rnd = new Random();

   for (int i = 0; i < arr.Length; i++)
   {
      arr[i] = rnd.NextDouble() * (max - min) + min;
   }
   return arr;
}

void PrintArray(double[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
      double round = Math.Round(arr[i], 1);
      if (i < arr.Length - 1) Console.Write($"{round}, ");
      else Console.Write($"{round}");
   }
}

double MaxNumberInArray(double[] arr)
{
   double max = arr[0];
   for (int i = 1; i < arr.Length; i++)
   {
      if(arr[i]>max) max = arr[i];
   }
   return max;
}

double MinNumberInArray(double[] arr)
{
   double min = arr[0];
   for (int i = 1; i < arr.Length; i++)
   {
      if (arr[i] < min) min = arr[i];
   }
   return min;
}

double Difference(double max,double min)
{
   return max - min;
}

double[] array = CreateArrayRndDouble(4, 0, 20);
double max = MaxNumberInArray(array);
double min = MinNumberInArray(array);
double difference = Math.Round(Difference(max, min), 1);
Console.Write("[");
PrintArray(array);
Console.Write($"] -> {difference}");

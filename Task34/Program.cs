// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
   int[] arr = new int[size];
   Random rnd = new Random();

   for (int i = 0; i < arr.Length; i++)
   {
      arr[i] = rnd.Next(min, max + 1);
   }
   return arr;
}

void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
      if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
      else Console.Write($"{arr[i]}");
   }
}
int EvenNumbers(int[] array)
{
   int result = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i]%2==0) result += 1;
   }
   return result;
}

int[] array=CreateArrayRndInt(8, 100, 999);
int result = EvenNumbers(array);
Console.Write("[");
PrintArray(array);
Console.Write($"] -> {result}");
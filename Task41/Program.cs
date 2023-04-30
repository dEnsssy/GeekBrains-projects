// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(number);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
int valueNumbers = ValueNumbers(array);
Console.WriteLine(valueNumbers);

int[] FillArray(int size)
{
   int[] array = new int[size];
   for (int i = 0; i < array.Length; i++)
   {
      array[i]=Convert.ToInt32(Console.ReadLine());
   }
   return array;
}

void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
      if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
      else Console.Write($"{arr[i]}");
   }
}

int ValueNumbers(int[] array)
{
   int result = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i]>0) result++;
   }
   return result;
}
// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void Pow2(int num)
{
   int count = 1;
   while (count <= num)
   {
      Console.WriteLine($"{count,3} {Math.Pow(count, 2),4}");
      count++;
   }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Pow2(number);
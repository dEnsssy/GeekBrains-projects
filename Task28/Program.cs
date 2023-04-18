// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int PowNumbers(int num)
{
   int pow = 1;
   for (int i = 1; i <= num; i++)
   {
      checked
      {
         pow *= i;
      }
   }
   return pow;
}
Console.WriteLine("Введите целое положительное число: ");
int number =Convert.ToInt32(Console.ReadLine());
int result = PowNumbers(number);
Console.WriteLine(result);
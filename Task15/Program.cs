// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
bool WeekDays(int num)
{
   if(num > 0 && num < 8)
      return true;
   else
      return false;
}
bool DayOff(int num1)
{
   if (num1>5)
      return true;
   else
      return false;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (WeekDays(number))
   if (DayOff(number))
      Console.WriteLine("Да");
   else
      Console.WriteLine("Нет");
else
   Console.WriteLine("Такого дня недели нет.");
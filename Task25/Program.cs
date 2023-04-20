// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degree = Degree(numberA, numberB);
if(ValueB(numberB))
   Console.WriteLine(degree);


int Degree(int a,int b)
{
   int result = 1;
   for (int i = 0; i < b; i++)
   {
      result *= a;
   }
   return result;
}

bool ValueB(int b)
{
   if (b<0)
      return false;
   return true;
}
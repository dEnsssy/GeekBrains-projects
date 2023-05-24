// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akkerman(int numberA, int numberB)
{
   if (numberA == 0)
      return numberB + 1;
   else
     if ((numberA != 0) && (numberB == 0))
      return Akkerman(numberA - 1, 1);
   else
      return Akkerman(numberA - 1, Akkerman(numberA, numberB - 1));
}

Console.WriteLine("Введите целое положительное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int akkerman = Akkerman(numberA, numberB);
Console.WriteLine(akkerman);
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99 && number<1000)
{
   int result = secondDigit(number);
   Console.WriteLine(result);
}
else
   Console.WriteLine("Вы ввели не трёхзначное число");

int secondDigit(int num)
{
   return num % 100 / 10;
}
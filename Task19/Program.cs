// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0) number = -number;
if (number>10000&& number<99999)
{
   bool palindrome = Palindrome(number);
   Console.WriteLine(palindrome?"Да":"Нет");
}
else
   Console.WriteLine("Вы ввели некорректное число");

bool Palindrome(int num)
{
   if ((num%10==num/10000)&&(num/1000%10==num%100/10))
      return true;
   else
      return false;
}
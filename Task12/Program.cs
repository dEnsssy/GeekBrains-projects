// 12.Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// 16, 4 -> кратно

int Remainder(int numA, int numB)
{
   int remainder = numA % numB;
   return remainder;
}
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе  число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Remainder(numberA, numberB);
// if (result==0) 
//    Console.WriteLine("Кратное");
// else 
//    Console.WriteLine($"Некратное, остаток {result}");
string res = result == 0 ? "Кратное" : $"Некратное, остаток {result}";
Console.WriteLine(res);
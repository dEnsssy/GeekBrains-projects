// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int sumNumbers=SumNumbers(numberA,numberB);
Console.WriteLine(sumNumbers);

int SumNumbers(int numA,int numB)
{
   if (numA==numB) return numB;
   else return numA+SumNumbers(numA+1,numB);
}
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool ValueTriangle(int numA,int numB,int numC)
{
   if (numA<numB+numC && numB<numA+numC && numC<numA+numB) return true;
   else return false;
}
bool valueTriangle = ValueTriangle(numberA, numberB, numberC);
Console.WriteLine(valueTriangle?"Существует":"Не существует");
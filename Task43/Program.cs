// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindX(double k1,double k2,int b1,int b2)
{
   return (b2 - b1) / (k1 - k2);
}
double FindY(double k, double b,double x)
{
   return k * x + b;
}

Console.WriteLine("B1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("K1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("B2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("K2:");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1==k2) Console.WriteLine("Прямые парал") ;
else
{
double x = FindX(k1,k2,b1,b2);
double y = FindY(k1, b1, x);
Console.Write("(");
Console.Write($"{x}, {y}");
Console.WriteLine(")");
}
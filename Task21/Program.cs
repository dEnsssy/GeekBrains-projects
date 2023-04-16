// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84

// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zACoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zBCoordinate = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xACoordinate, yACoordinate, zACoordinate, xBCoordinate, yBCoordinate, zBCoordinate);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(distanceRound);

double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
   return Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
}
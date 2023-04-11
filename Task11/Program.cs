// 11.Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

Console.WriteLine(FinishNumber(number));

int FinishNumber(int num)
{
   int firstDigit = num / 100;
   int thirdDigit = num % 10;
   int finishNumber = firstDigit * 10 + thirdDigit;
   return finishNumber;
}



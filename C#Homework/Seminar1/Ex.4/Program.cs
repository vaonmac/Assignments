// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int Num3 = Convert.ToInt32(Console.ReadLine());
int max = Num1;
if (Num2 > max) max = Num2;
if (Num3 > max) max = Num3;
Console.WriteLine("Максимальное из трех чисел = " + max);
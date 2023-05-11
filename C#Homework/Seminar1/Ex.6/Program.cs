//Задача 6. Напишите программу, которая принимает на вход число и выдает. является ли число четным.
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num == 0) Console.WriteLine("Вы ввели ноль");
else if (Num % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");

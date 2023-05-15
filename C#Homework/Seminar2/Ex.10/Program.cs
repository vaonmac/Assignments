// Задача 10. Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 0) Num = -Num;
if (Num > 99 & Num < 1000) Console.WriteLine(Num % 100 / 10);
else Console.WriteLine("Ошибка! Введите трехзначное число");
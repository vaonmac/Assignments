// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру дня недели");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num == 6 | Num == 7) Console.WriteLine("Да, выходной");
else if (Num > 0 & Num < 6) Console.WriteLine("Нет, рабочий");
else Console.WriteLine("Ошибка! ведите цифру дня недели от 1 до 7");

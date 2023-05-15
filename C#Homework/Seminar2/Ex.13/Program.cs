// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что такой цифры нет.
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 0) Num = -Num;
if (Num > 99) 
{
    while (Num > 999) 
        Num = Num /10;
    Console.WriteLine(Num % 10);
}
else Console.WriteLine("В этом числе нет третьей цифры");
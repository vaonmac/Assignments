//Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее. Второй вариант - как в условии.

Console.WriteLine("Введите первое число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Num2 = Convert.ToInt32(Console.ReadLine());
int max = Num1, min = Num2;
if (Num2 > max) 
{
    max = Num2; 
    min = Num1;
}
Console.WriteLine("Большее число = " + max);
Console.WriteLine("Меньшее число = " + min);
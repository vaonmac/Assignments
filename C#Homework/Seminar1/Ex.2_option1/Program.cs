//Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее. Первый вариант - как в примере.
Console.WriteLine("Введите первое число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Num2 = Convert.ToInt32(Console.ReadLine());
int max = Num1;
if (Num2 > max) max = Num2;
Console.WriteLine("max = " + max);

// Задача 8. Напишите программу, которая на входе принимает число N, а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int Start = 2;
int Finish = N;
if (N <= -2)
{
    Start = N;
    Finish = -2;
}
else if (N > -2 & N < 2) Console.WriteLine("В этом интервале четных чисел нет");
while (Start <= Finish)
{
    Console.Write(Start + "; ");
    Start += 2;
}

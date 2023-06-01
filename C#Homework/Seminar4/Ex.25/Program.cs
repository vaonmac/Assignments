// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Exponent (int Num1, int Num2)
{
    int result = Num1;
    for (int i = 1; i < Num2; i++) result = result * Num1;
    return result;
}

System.Console.WriteLine("Введите числа A и B");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {A} в натуральной степени {B}: {Exponent (A, B)}");

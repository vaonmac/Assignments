// Задача № 23. Напишите программу, которая принимает на вход числоN и выдает таблицу кубов чисел от 1 до N.
void CubeTable (int Num)
{
    Console.WriteLine("Число   Куб числа");
    if (Num > 0)
    {
        for (int Count = 1; Count <= Num; Count++) Console.WriteLine($"  {Count}        {Math.Pow(Count, 3)}");
    }
    else for (int Count = 1; Count >= Num; Count--) Console.WriteLine($"  {Count}        {Math.Pow(Count, 3)}");
}


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
CubeTable (N);

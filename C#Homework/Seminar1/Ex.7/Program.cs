//Задача 7. Напишите программу, которая на входе принимает целое число любой разрядности, а на выходе выдает вторую слева цифру этого числа или говорит, что такой цифры нет.
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 0) Num = -Num;
if (Num > 9) 
{
    while (Num > 99) 
    {
        Num = Num /10;
    }
    Console.WriteLine(Num % 10);
}
else Console.WriteLine("В этом числе нет второй цифры");

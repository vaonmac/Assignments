// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome5 (int Num)
{   
    if (Num < 0) Num = -Num;
    if (Num <10000 || Num > 99999 || Num == 0) Console.WriteLine("Ошибка! Это не пятизначное число");
    else if (Num / 10000 == Num % 10 && Num / 1000 % 10 == Num % 100 / 10) Console.WriteLine("Это палиндром");
    else Console.WriteLine("Это число не является палиндромом");
}


Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome5 (number);
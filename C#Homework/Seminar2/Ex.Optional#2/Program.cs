// Задача необязательная 2. Напишите программу, которая на входе принимает целое число n (неотрицательное) и на выходе выводит это число со словом "программист" в соответствующем падеже
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if ((Num % 100 != 11) && Num % 10 == 1) Console.WriteLine(Num + " программист");
else if ((Num % 100 < 12 || Num % 100 > 14) && Num % 10 > 1 && Num % 10 < 5) Console.WriteLine(Num + " программиста");
else Console.WriteLine(Num + " программистов");
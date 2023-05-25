// Задача № 21. Напишите программу, которая на вход принимает координаты двух точек и находит расстояние между ними в 3D-пространстве.

double Distance (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double Result = Math.Sqrt(Math.Pow (x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Result;
}

Console.WriteLine("Введите координаты x, y и z первой точки");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x, y и z второй точки");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Расстояние между этими точками в 3D-пространстве: " + Distance (xa, xb, ya, yb, za, zb));

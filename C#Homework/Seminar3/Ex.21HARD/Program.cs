// Задача 21 - HARD необязательная. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек

void CoordArray (double [] array)
{
	int length = array.Length;
		for (int index = 0; index < length; index++)
    	{
		Console.WriteLine($"Введите {index +1}-ю координату точки");
        array [index] = Convert.ToDouble(Console.ReadLine());
	    }
}
double DistanceND (double [] Point1, double [] Point2)
{      int length = Point1.Length;
       double Result = 0;
       for (int index = 0; index < length; index++)
       {
       Result = Result + (Math.Pow (Point2[index] - Point1[index], 2));
       }
       return Math.Sqrt(Result);
}
Console.WriteLine("Введите число, обозначающее мерность пространства");
int dimension = Convert.ToInt32(Console.ReadLine());
double [] pointA = new double[dimension];
Console.WriteLine("Введите координаты первой точки:");
CoordArray (pointA);
double [] pointB = new double[dimension];
Console.WriteLine("Введите координаты второй точки:");
CoordArray (pointB);
Console.WriteLine($"Расстояние между этими точками в {dimension}D пространстве: {DistanceND (pointA, pointB)}");
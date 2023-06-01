// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void RandomArray8 ()
{
    int [] Array = new int[8];
    int length = Array.Length;
    Console.Write ("[");
    for (int i = 0; i < length; i++) 
    {
        Array [i] = new Random().Next(0, 100);
        Console.Write (Array [i]);
        if (i < length-1) Console.Write (",");
    }
    Console.WriteLine ("]");
}

RandomArray8 ();

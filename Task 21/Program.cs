﻿Console.Clear();
Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double s = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 -z2), 2));
Console.WriteLine($"s = {s:f2}");
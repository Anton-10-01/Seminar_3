﻿/* 17. Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве
A(3, 6); B(2, 1) -> 5,09
A(7, -5); B(1, -1) -> 7,21
*/

Console.Write("Введите координату X точки 1: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки 2: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки 1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y точки 2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(a1, b1, a2, b2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {resultRound}");

double Distance(int x1, int x2, int y1, int y2) {
    int cat1 = x1 - x2;
    int cat2 = y1 - y2;
    double dist = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return dist;
}

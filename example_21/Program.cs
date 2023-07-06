﻿/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координату X точки 1: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y точки 1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z точки 1: ");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки 2: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y точки 2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z точки 2: ");
int c2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(a1, b1, c1, a2, b2, c2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {resultRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2) {
    int distX = x2 - x1;
    int distY = y2 - y1;
    int distZ = z2 - z1;
    double dist = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2) + Math.Pow(distZ, 2));
    return dist;
}
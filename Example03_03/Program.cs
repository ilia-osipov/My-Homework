﻿// Задача 23
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int k = num;

if (num < 0) k = -num;
 
for(int i = 1; i <= k; i++)
{
    Console.WriteLine($"i = {i} -> i * i * i = {i*i*i} ");
}
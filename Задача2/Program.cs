﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2==0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
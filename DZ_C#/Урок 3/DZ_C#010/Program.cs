﻿//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: "); 

int x = 1; 
int number = Convert.ToInt32(Console.ReadLine()); 
do 
{ 
    Console.WriteLine(Math.Pow(x++, 3)); 
} 
while (number >= x);
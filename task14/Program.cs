﻿// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());

if (Check(number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool Check(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
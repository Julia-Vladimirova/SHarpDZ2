﻿
// : Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Это не день недели";
string check(int number)
{
    if (number >= 5 && number < 8) ss = "Это Выходной";
    if (number >= 1 && number < 6) ss = "Это будний день";
    return ss;
}
System.Console.WriteLine(check(number));
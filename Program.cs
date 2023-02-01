﻿//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


int posNum1 = 3;
int posNum2 = 2;

int Akkerman = GetAkkerman(posNum1, posNum2);
Console.Write($"m = {posNum1}, n = {posNum2} - > A(m,n) = {Akkerman}");

int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return GetAkkerman(m - 1, 1);
    else return GetAkkerman(m - 1, GetAkkerman(m, n - 1));

}
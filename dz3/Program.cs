﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkFunction(a, b));




int AkkFunction(int a, int b)
{
    if(a==0) return b+1;
    else  if (b==0) return AkkFunction(a-1,1);
    else return AkkFunction(a-1,AkkFunction(a,b-1));
}
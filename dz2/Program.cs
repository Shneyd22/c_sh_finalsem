// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a<b)
Console.WriteLine(PrintNumbers1(a, b));
if (a>b)
Console.WriteLine(PrintNumbers2(a, b));





int PrintNumbers1(int a, int b)
{
    if(a==b) return a;
    return a + PrintNumbers1(a+1, b);
}

int PrintNumbers2(int a, int b)
{
    if(a==b) return a;
    return a + PrintNumbers2(a-1, b);
}
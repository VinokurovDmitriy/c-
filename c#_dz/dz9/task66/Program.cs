// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetSum(int m, int n)
{
   return m == n ? m : m + GetSum(m + 1, n);
}
Console.WriteLine($"Сумма всех чисел от {m} до {n} = {GetSum(m, n)}");


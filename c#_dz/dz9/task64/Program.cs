// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int NumSum( int num )
{
    if(num < 10) 
    {
        return num;
    }
    else 
    {
       return ((num % 10) + NumSum( num / 10 ));
    }
}

Console.WriteLine($"Сумма цифр числа {n} = {NumSum(n)}");
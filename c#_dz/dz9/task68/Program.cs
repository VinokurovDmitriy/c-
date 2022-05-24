// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

bool correctEnter = false;
int m = 0;
int n = 0;
while(!correctEnter)
{
    Console.Write("Введите число m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    n = Convert.ToInt32(Console.ReadLine());
    correctEnter = m > 0 && n > 0;
}
int FunctionAckermann(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return FunctionAckermann(n - 1, 1);
                return FunctionAckermann(n - 1, FunctionAckermann(n, m - 1));
            }

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {FunctionAckermann(m, n)}");

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int FunctionAckermann(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return FunctionAckermann(n - 1, 1);
                if (n > 0 && m > 0) return FunctionAckermann(n - 1, FunctionAckermann(n, m - 1));
                return FunctionAckermann(n,m);
            }

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {FunctionAckermann(m, n)}");
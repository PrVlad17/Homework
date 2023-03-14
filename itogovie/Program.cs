//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
int N = 10;
PrintNumbers(N);
void PrintNumbers(int n)
    {
        if (n <= 0)
        {
            return;
        }
        Console.WriteLine(n);
        PrintNumbers(n - 1);
    }

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int M = 1;
int N = 10;
int sum = 0;
for (int i = M; i <= N; i++)
{
     sum += i;
}
Console.WriteLine($"Сумма чисел от {M} до {N}: {sum}");

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
int m = 3;
int n = 1;
int result = Ackermann(m, n);
 Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

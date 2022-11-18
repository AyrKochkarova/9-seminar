// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное число M:");
int m = Convert.ToInt32(Console.ReadLine());
while (m <= 0)
{
    Console.WriteLine("Число должно быть положительным. Повторите ввод числа M:");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите положительное число N:");
int n = Convert.ToInt32(Console.ReadLine());

while (n <= 0)
{
    Console.WriteLine("Число должно быть положительным. Повторите ввод числа N:");
    n = Convert.ToInt32(Console.ReadLine());
}

FunctionAkkerman(m, n);
Console.WriteLine($"Значение функции Аккермана: {FunctionAkkerman(m, n)}");

int FunctionAkkerman(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }

    return FunctionAkkerman(m, n);
}

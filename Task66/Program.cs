// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());
while (m <= 0)
{
    Console.WriteLine("Число должно быть натуральным. Повторите ввод числа M:");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

while (n <= 0)
{
    Console.WriteLine("Число должно быть натуральным. Повторите ввод числа N:");
    n = Convert.ToInt32(Console.ReadLine());
}

void SumNaturalNumbers(int num1, int num2, int sum)
{

    if (num1 > num2)
    {
        Console.Write($"Cумма натуральных элементов в промежутке от M до N равна {sum} ");
    }
    else
    {
        sum += num1;
        SumNaturalNumbers(num1 + 1, num2, sum);
    }

}

if (m < n)
SumNaturalNumbers(m, n, 0);
else
SumNaturalNumbers(n, m, 0);
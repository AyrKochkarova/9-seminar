// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M:");
int number1 = Convert.ToInt32(Console.ReadLine());
while (number1 <= 0)
{
    Console.WriteLine("Число должно быть натуральным. Повторите ввод числа M:");
    number1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите натуральное число N:");
int number2 = Convert.ToInt32(Console.ReadLine());

while (number2 <= 0)
{
    Console.WriteLine("Число должно быть натуральным. Повторите ввод числа N:");
    number2 = Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int num1, int num2, int sum)
{

    if (num1 > num2)
    {
        Console.Write($"Cумма натуральных элементов в промежутке от M до N равна {sum} ");
    }
    else
    {
        sum += num1;
        NaturalNumbers(num1 + 1, num2, sum);
    }

}

if (number1 < number2)
NaturalNumbers(number1, number2, 0);
else
NaturalNumbers(number2, number1, 0);
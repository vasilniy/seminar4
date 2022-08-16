// Задача 1. Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

int FindSum(int number)
{
    int sum = 0;

    for (int current = 1; current <= number; current++ )
        sum += current;

    return sum;
}

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindSum(a);

Console.WriteLine($"Сумма чисел от 1 до {a} равна = {result}");
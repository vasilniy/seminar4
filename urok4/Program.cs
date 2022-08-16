// Задача 1. Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int number)
{
    int sum = 0;

    for (int current = 1; current <= number; current++ )
        sum += current; // тоже самое, что sum = sum + current

    return sum;
}

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindSum(a);

Console.WriteLine($"Сумма чисел от 1 до {a} равна = {result}");
*/

// Задача 2. Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
/*
int FindDigit (int number)
{
    int current = 0;
    while (number > 0)
    {
        number = number / 10;
        current++;
    }
    return current;
}

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Количство цифр: {FindDigit(a)}");
*/

// Задача 3. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
/*
int FindFactorial(int number)
{
    int fac = 1;

    for (int current = 1; current <= number; current++ )
        fac *= current;

    return fac;
}

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindFactorial(a);
Console.WriteLine($"Сумма чисел от 1 до {a} равна = {result}");
*/

// Задача 4. Напишите программу, которая выводит массив из
// 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);

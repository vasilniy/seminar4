// Задача 1. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if (ed > dec)
    {
        max = ed;
    }
    else
    {
        max = dec;
    }

    return max;
}

Console.Write("Рандомное двузначное число = ");
int randomNamber = new Random().Next(10, 100);
Console.Write(randomNamber);

int biggestDigit = FindBiggestDigit(randomNamber);
Console.WriteLine();
Console.WriteLine($"Большее число из этих двух это: {biggestDigit}");
*/

// Задача 2. Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    int result = sot * 10 + ed;
    return result;
}

Console.Write("Рандомное трехзначное число = ");
int randomNamber = new Random().Next(100, 1000);
Console.Write(randomNamber);
int biggestDigit = CutNumber(randomNamber);
Console.WriteLine();
Console.WriteLine($"Новая версия это: {biggestDigit}");
*/

// Задача 3. Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит
// остаток от деления.

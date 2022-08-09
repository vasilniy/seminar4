// Задача 1. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

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


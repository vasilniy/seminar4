// Задача 1. Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива.

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

void FindMinMaxSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];        
    }
    Console.WriteLine("Сумма отрицателных = " + sumNegative);
    Console.WriteLine("Сумма положительных = " + sumPositive);
}


Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);

FindMinMaxSum(myArray);

// Задача 1. Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива.
/*
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
*/

// Задача 2. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
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

int[] NewArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array [i] * (-1);       
    return array;
}



Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);

ShowArray(NewArray(myArray));
*/

// Задача 3. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
/*
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

bool CheckNumber (int [] array, int n)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) return true;        
    }
    return false;
}

Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
bool check = CheckNumber(myArray, number);

if (check == true) Console.WriteLine($"Число {number} найдено");
else Console.WriteLine($"Число {number} нет в массиве");

*/


// Задача 4. Задайте одномерный массив из 12 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountElements(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    return count;
}


Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин. значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс. значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи мин. число отрезка: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс. число отрезка: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);

int result = CountElements(myArray, min1, max1);
Console.WriteLine($"Количество элементов массива, в заданном диапозоне = {result}");
*/

// Задача 5. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] CompositPairsElement(int[] array)
{
    int[] newArray = new int[array.Length/2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newArray;
}

Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин. значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс. значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(CompositPairsElement(myArray));
*/

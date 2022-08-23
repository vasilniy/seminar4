// Задача №1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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
*/
/*
int [] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array.Length - 1 -i;
        array[array.Length - 1 - i] = temp;
    }

    return array;
}
*/
/*int [] ReverseArray(int[] array) // перевернет массив
{
    for(int i = 0, j = array.Length -1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}

Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин. значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс. значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

// Задача 2. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// (пример, каждая сторона должна быть меньше суммы двух других сторон a < b + c)
/*
bool TriangleSide(int a, int b, int c)
{    
    if (a < b +c && b < a + c && c < b + a) return true;
    else return false;
}

Console.Write("Введи сторону а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи сторону b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи сторону c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (TriangleSide(a,b,c)) Console.WriteLine ("треугольник");
else Console.WriteLine ("Не треугольник");

*/


// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: a и b.
/*
void Fibonachchi (int n, int a, int b)
{
    Console.Write($"{a} {b} ");
    int fib = a + b;
    int fib2 = b;
    int fib3 = 0;
    for (int i = 0; i <= n; i++)
    {
        Console.Write($"{fib} ");
        fib3 = fib + fib2;
        fib2 = fib;
        fib = fib3;
    }

}

Console.Write("Введи сколько цифр надо: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи первое число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Fibonachchi(n, a, b);
*/
// Задача 4. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.


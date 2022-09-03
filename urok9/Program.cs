// Задача №1. Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
/*
void ShowNumbers(int n) // Рекурсия
{
    if(n > 1) ShowNumbers(n - 1);
    Console.Write(n + " ");
}

ShowNumbers(10);

*/

// Задача №2. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.

/*
int FindSum (int n) // Рекурсия
{
    if (n > 0) 
        return FindSum (n / 10) + n % 10;
    else
        return n;
}
Console.WriteLine();
Console.WriteLine(FindSum(12345));
*/

// Задача 3. Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(int m, int n) // Рекурсия
{
    if(m < n) ShowNumbers(m, n - 1);
        Console.Write(n + " ");    
}
ShowNumbers(5, 20);
*/

// Задача 4. Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

int NumberPower (int A, int B)
{
    if(B != 0) 
    {
        return NumberPower(A, B - 1) * A;
    }
    return 1;
}
Console.WriteLine(NumberPower(2,15));
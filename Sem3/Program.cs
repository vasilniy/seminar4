// Math.Sqrt(x); - Корень из х, всегда тип - double lenght = Math.Sqrt(x);


// Задача 1. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return 0;
}

Console.Write("Веедите первое число: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите второе число: ");
double yA = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuart(xA, yA);

if (quartNum == 0)
    Console.WriteLine("Точка находится на осях, как-то так.");
else
    Console.WriteLine($"Точка находится в {quartNum} четверти.");
*/

// Задача 2. Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void FindCoordinat(int quart)
{
    if(quart == 1) Console.WriteLine($"Диапозон (X+ ; Y+)");
    if(quart == 2) Console.WriteLine($"Диапозон (X- ; Y+)");
    if(quart == 3) Console.WriteLine($"Диапозон (X- ; Y-)");
    if(quart == 4) Console.WriteLine($"Диапозон (X+ ; Y-)");
}

Console.Write("Веедите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

FindCoordinat(num);
*/

// Задача 3. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// Формула вычисления расстояния между двумя точками
// A(xa, ya) и B(xb, yb) на плоскости:
// AB = √(xb - xa)2 + (yb - ya)2
// Math.Pow(xb-xa, 2); - возведение в степень
/*
double FindDistance (double x1, double y1, double x2, double y2)
{
    double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return dist;
}

Console.Write("Веедите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());


Console.Write($"Расстояние между точками = {FindDistance(x1, y1, x2, y2)}");
*/

// Задача 4. Напишите программу, которая принимает
// на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.

void SquareNumber(int N)
{
    int current = 1;
    while(current <= N)
    {
        Console.WriteLine($"Квадрат числа {current} = {current*current}");
        current++;
    }    
}

Console.Write("Веедите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareNumber(number);



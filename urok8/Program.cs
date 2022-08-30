// Задача 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
/*
int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void Show2dArray(int[,] array) // Вывод 2-мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
    Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) || row2 >= array.GetLength(1))
        return array;
    else
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2,j];
            array[row2, j] = temp;
        }
    }

    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин знач: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс знач: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n,min,max);
Show2dArray(myArray);
ChangeRows(myArray, 0, 2);
Show2dArray(myArray);
*/

// Задача2. Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.
/*
int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void Show2dArray(int[,] array) // Вывод 2-мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
    Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ChangeRowsColumns (int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
        int temp = array[i,j];
        array[i,j] = array[j, i];
        array[j, i] = temp;
        }

    return array;    
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин знач: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс знач: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n,min,max);
Show2dArray(myArray);
ChangeRowsColumns(myArray);
Show2dArray(myArray);

*/
// Задача3. Из двумерного массива целых чисел удалить строку
// и столбец, на пересечении которых расположен наименьший элемент.

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void Show2dArray(int[,] array) // Вывод 2-мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
    Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FindMinNumber (int[,] array)
{
    int imin = 0;
    int jmin = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[imin, jmin])
            {
                imin = i;
                jmin = j;
            }
        }
    
    for(int i = 0; i < array.GetLength(0); i++)
        array[i, jmin] = 0;
    for(int j = 0; j < array.GetLength(1); j++)
        array[imin, j] = 0;

    return array;  
}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин знач: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс знач: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n,min,max);
Show2dArray(myArray);
FindMinNumber(myArray);
Show2dArray(myArray);



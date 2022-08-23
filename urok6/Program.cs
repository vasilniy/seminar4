// Задача №1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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
int [] ReverseArray(int[] array) // перевернет массив
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

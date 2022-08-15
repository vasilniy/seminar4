// Урок 3. Цикл в цикле for ()
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        int result = i * j;
        Console.WriteLine($"{i} * {j} = {result}; ");
    }
    Console.WriteLine();
}
*/


// Задача по сортировке наименьшего значения массива в леву часть.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1,5 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j; // меняем знак > или <
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);

SelectionSort(arr);

PrintArray(arr);
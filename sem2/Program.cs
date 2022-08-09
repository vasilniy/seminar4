// Лекция по С# №2
Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        
        index++;
    }
    return position;
}

int[] array = new int[10];

Console.Write("Введи цифру, которую ищем: ");
int f = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, f);
if (pos == -1)
{
    Console.WriteLine("А нихрна нет такого элемента");
}
else
{Console.WriteLine(pos);}











/*
while (index < n)
{
    Console.WriteLine($"{index} элемент = {array[index]}");
    index++;
}

*/

/*int[] array = { 11, 12, 12, 4, 11, 11, 4, 23, 23 };

int n = array.Length;

int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
*/
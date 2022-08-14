// Урок 3. Цикл в цикле for ()

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        int result = i * j;
        Console.WriteLine($"{i} * {j} = {result}; ");
    }
    Console.WriteLine();
}
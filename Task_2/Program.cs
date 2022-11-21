// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Execute()
{
    int m = Prompt("Введите количество строк массива: ");
    int n = Prompt("Введите количество столбцов массива: ");
    int[,] array = FillArray(m, n);
    PrintArray(array);
    int numM = Prompt("Введите № строки массива: ");
    int numN = Prompt("Введите № столбца массива: ");
    if (numM < 0 || numN < 0 || numM > m || numN > n)
    {
        Console.WriteLine("В заданном массиве такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение искомого элемента: {array[numM - 1, numN - 1]}");
    }
}

Execute();
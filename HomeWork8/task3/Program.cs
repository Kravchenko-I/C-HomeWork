// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();


Console.WriteLine("Введите колличество строк массива:");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива:");
int columns = int.Parse(Console.ReadLine());

/// Создание случайного двумерного массива
int [,] GetArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(1, 10);
                }
            }
    return array;
}

/// Метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}

/// Метод нахождения среднего арифметического каждого столбца массива
void AverageArrayColumns(int[,] array)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца {Math.Round(result / array.GetLength(0), 1)}");
        result = 0;
    }
}


int [,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
AverageArrayColumns(array);

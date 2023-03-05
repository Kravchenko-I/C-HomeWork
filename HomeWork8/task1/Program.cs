//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.


Console.Clear();
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

int [,] array = GetArray(4, 4);

/// Метод поиска элемента массива
void SearchArrayIndex (int userRow, int userColumn)
{
    if (userRow <= array.GetLength(0) - 1 && userColumn <= array.GetLength(1) - 1)
        Console.WriteLine($"Значение элемента в указанной позиции = [{userRow},{userColumn}] = {array[userRow,userColumn]}");
    else if (userRow > array.GetLength(0) - 1 || userColumn > array.GetLength(1) - 1)
        Console.WriteLine($"Не существует элемента в указанной позиции = [{userRow},{userColumn}]");
}


Console.WriteLine("Введите номер строки массива: ");
int userRow = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер столбца массива: ");
int userColumn = int.Parse(Console.ReadLine());

PrintArray(array);
SearchArrayIndex(userRow, userColumn);
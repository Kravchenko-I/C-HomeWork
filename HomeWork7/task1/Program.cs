//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double [] array = new double[4];
double x = 0;
double y = 0;

/// Метод заполнения значений данными пользователя:
void AssignmentValue(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"Введите значение: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

/// Метод нахождения пересечения двух прямых:
void SearchCollision(double [] array)
{
    x = (array[2] - array[0]) / (array[1] - array[3]);
    y = array[1] * x + array[0];
}

Console.WriteLine("Введите значения x1, y1, x2, y2:");

AssignmentValue(array);
SearchCollision(array);

Console.WriteLine($"Две прямые пересекаются в точке: ({x}; {y})");

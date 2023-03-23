// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.

Console.WriteLine("Введите количество строк m: ");
int countRow = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n: ");
int countColumn = int.Parse(Console.ReadLine());
double[,] array = new double[countRow, countColumn];
for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        Console.Write(array[i,j] + "  ");
    }
    Console.WriteLine();
}


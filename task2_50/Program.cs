// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого 
//элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Номер строки m: ");
int countRow = int.Parse(Console.ReadLine());
Console.WriteLine("Номер столбца n: ");
int countColumn = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

if (countRow > array.GetLength(0) || countColumn > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {array[countRow-1,countColumn-1]}");

}
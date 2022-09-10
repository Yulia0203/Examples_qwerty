// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A(i+1) = m+n
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите количество строк:");
bool inNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов:");
bool inNumbern = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberm || m <= 0 || !isNumbern || n <= 0);
{
    Console.WriteLine("Данные введены неверно");
    return;
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i =0; i < array.GetLength(0); i++)
    {
         for (int j =0; j < array.GetLength(0); j++)
         {
            array[i, j] = i+j;
        }
    }
    return array;
}
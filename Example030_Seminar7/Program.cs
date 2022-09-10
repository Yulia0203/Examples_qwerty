// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A(i+1) = m+n
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите количество строк:");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);

if (isNumberm == false || m < 1)
{
    Console.WriteLine("Некорректное число");
    return;
}

Console.WriteLine("Введите количество столбцов:");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);

if (isNumbern == false || n < 1)
{
    Console.WriteLine("Некорректное число");
    return;
}


int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i =0; i < array.GetLength(0); i++)
    {
         for (int j =0; j < array.GetLength(1); j++)
         {
            array[i, j] = i+j;
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] result = CreateRandomArray(m,n);
Print2DArray(result);

// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените эти элементы
// на их квадраты


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
void ReplaceToSquareChetIndexArrayTwodimInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] result = CreateRandomArray(m,n);
ReplaceToSquareChetIndexArrayTwodimInt(result);

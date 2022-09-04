// Задайте массив из 12 элементов, заполенные случайными числами из промежутка (-9, 9).
// Найдите сумму отрицательных и положительных элементов массива

Console.WriteLine("Введите длину массива: ");

bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber || length <= 0)
{
    Console.WriteLine("Неверное число");
    return;
}

int[] array = FillArray(length);
PrintArray(array);

int sumPositiveNumber = GetSumPositiveNumberInArray(array);
Console.WriteLine($"Сумма положительных чисел = {sumPositiveNumber}");

int sumNegativeNumber = GetSumNegativeNumberInArray(array);
Console.WriteLine($"Сумма отрицательных чисел = {sumNegativeNumber}");

int GetSumNegativeNumberInArray(int[] array)
{
    int sumNegativeNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sumNegativeNumber += array[i];
        }
            
    }
    return sumNegativeNumber;
}

int GetSumPositiveNumberInArray(int[] array)
{
    int sumPositiveNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumPositiveNumber += array[i];
        }
            
    }
    return sumPositiveNumber;
}


void PrintArray(int[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] FillArray(int length)
{
    int[]array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}
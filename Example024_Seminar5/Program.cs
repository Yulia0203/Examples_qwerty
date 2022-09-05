// Напишите программу, которая определяет, присутствует ли заданное число в массиве

//Проверка вводимого числа
Console.Write("Введите длину массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int a);

if (!isNumber)
{
    Console.WriteLine("Неверное число");
    return;
}

int [] array = GetArray(a);
Console.Write("Введите искомое значение: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int b);
Console.WriteLine(GetNumberTrueFalse(array, b));

//Заполняем массив
int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

//Ищем число в массиве
bool GetNumberTrueFalse(int[] array, int z)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == z);
        return true;
    }
    return false;
}


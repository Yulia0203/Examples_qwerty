// Найдите произведение чисел в одномером массиве. Парой считаем первый и последний элементы, второй 
// и предпоследний. Результат запишите в новом массиве

Random random = new Random();
int[] array = new int[4];
for(int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 10);
}
printArray(array);
System.Console.WriteLine();
printArray(GetMultiPair(array));

int[] GetMultiPair(int[] array)
{
    int[] arr;
    if(array.Length % 2 == 0)
    {
        arr = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            arr[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    else
    {
        arr = new int[array.Length / 2 + 1];
        for (int i = 0; i < array.Length / 2; i++)
        {
            arr[i] = array[i] * array[array.Length - 1 - i];
        }
        arr[arr.Length - 1] = array[array.Length / 2 + 1];
    }
    return arr;
}
void printArray(int[] array)
{
    foreach (int elem in array)
    {
        System.Console.WriteLine($"{elem}");
    }
}

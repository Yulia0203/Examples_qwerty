// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем)

int[] array = new int[] {1, 2, 3, 4, 5};
PrintArray(array);
int [] reverseArray = ReverseArray(array);
System.Console.WriteLine();
PrintArray(reverseArray);


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] ReverseArray(int[] array)
{
    int[] reverseArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        reverseArray[i] = array[array.Length - 1 - i];
    }
    return reverseArray;
}
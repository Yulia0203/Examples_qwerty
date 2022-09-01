// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// // [1, 0, 1, 1, 0, 1, 0, 0]

// void PrintSquares(int[] squares)
// {
//     int i = 0;
//     int Len = squares.Length;
//     while (i < Len)
//     {
//         System.Console.WriteLine((squares[i]));
//         i++;
//     }
// }
// int[] GenArray(int N)
// {
//     int[] arr = new int[N];
//     Random random = new Random();
//     int number = random.Next(0, 2);
//     for(int i = 0; i < N; i++)
//     {
//         arr[i] = random.Next(0, 2);
//     }
//     return arr;
// }
// PrintSquares(GenArray(8));

int[] PassArr(int n)
{
    int[] newArray = new int [n];
    for (int i = 0; i < n; i++)
    {
        newArray[i] = new Random().Next(0, 2);
    }
    return newArray;
}
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}");
    }
}
System.Console.WriteLine("Введите размер массива ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);
if (!isNumber) 
{
    System.Console.WriteLine("Неверное число!");
    return;
}
PrintArr(PassArr(number));


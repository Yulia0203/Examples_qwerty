// Напишите прошрамму, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

System.Console.WriteLine("Введите положительное число: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if(!isNumberN)
{
    System.Console.WriteLine("Вы ввели не число!");
    return;
}

PrintSquares(GetSquares(N));
int[] GetSquares(int n)
{
    int i = 1;
    int[] result = new int[n];
    while (i <= n)
    {
        result[i-1] = (int) Math.Pow (i, 2);
        i++;
    }
    return result;
}
void PrintSquares(int [] squares)
{
    int i = 0;
    int lenght = squares.Length;
    while (i < lenght)
    {
        System.Console.WriteLine((squares[i]));
        i++;
    }
}
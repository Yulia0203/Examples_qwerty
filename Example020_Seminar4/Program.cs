// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2

System.Console.WriteLine("Введите число N");
bool isNumber = int.TryParse(Console.ReadLine(), out int N);
if (!isNumber)
{
    System.Console.WriteLine("Это не число");
    return;
}

int GetLenNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}
int result = GetLenNumber(N);
System.Console.WriteLine(result);


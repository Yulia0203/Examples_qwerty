//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывет наибольшую цифру числа

Random random = new Random();
//для генерации рандомных чисел
int randomNumber = random.Next(10, 100);

Console.WriteLine(randomNumber);

int GetMaxNumber(int number)
{
    int lastNumber = number % 10;
    int firstNumber = number / 10;
    if (lastNumber > firstNumber)
    {
        return lastNumber;
    }
    else
    {
        return firstNumber;
    }
}
int result = GetMaxNumber(randomNumber);
Console.WriteLine(result);


// int lastNumber = randomNumber % 10;
// int firstNumber = randomNumber / 10;

// if(lastNumber > firstNumber)
// {
//     Console.WriteLine("Максимальное число равно " + lastNumber);
// }
// else
// {
//     Console.WriteLine("Максимальное число равно " + firstNumber);
// }

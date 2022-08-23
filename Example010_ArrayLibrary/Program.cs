//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывет наибольшую цифру числа

Random random = new Random();
//для генерации рандомных чисел
int randomNumber = random.Next(10, 100);

Console.WriteLine(randomNumber);

int lastNumber = randomNumber % 10;
int firstNumber = randomNumber / 10;

if(lastNumber > firstNumber)
{
    Console.WriteLine("Максимальное число равно " + lastNumber);
}
else
{
    Console.WriteLine("Максимальное число равно " + firstNumber);
}

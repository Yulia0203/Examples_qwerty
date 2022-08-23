//Напишите программу, которая выводит случаное трехзначное число и удаляет вторую цифру этого числа

Random random = new Random();
int RandomNumber = random.Next(100, 1000);

Console.WriteLine(RandomNumber);

int firstNumber = RandomNumber / 100;
int secondNumber = RandomNumber % 10;

int result = (firstNumber * 10) + secondNumber;
Console.WriteLine(result);



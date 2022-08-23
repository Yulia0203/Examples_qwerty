// Напиишите программу, которая будет принимать на вход два числа и выводить, 
//являетмя ли второе число кратным первому. 
//Если число 2 не кратно 1, то программа выводит отстаток от деления

Console.Write("Введите число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber % secondNumber;

if(result == 0)
{
    Console.Write("Кратно");
}
else
{
    int ostatok = firstNumber % secondNumber;
    Console.WriteLine(ostatok);
}


